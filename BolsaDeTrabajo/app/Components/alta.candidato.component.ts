import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { ActivatedRoute, CanDeactivate, Router,} from '@angular/router';
import { CalendarModule, AutoCompleteModule, CheckboxModule } from 'primeng/primeng'; 

import { AltaCandidatoValidator } from './alta.candidato.validators';
import { CURPValidator } from './Validators/CURP.validator';
import { CatalogosService } from '../Services/catalogos.service';
import { CandidatosService } from '../Services/Candidatos.Service';
import { PerfilImageService } from '../Services/ProfileImage.service';
import { IEstadoCivil } from '../Models/IEstadoCivil';
import { IGenero } from '../Models/IGenero';
import { IPais } from '../Models/IPais';
import { IEstado } from '../Models/IEstado';
import { IMunicipio } from '../Models/IMunicipio';
import { ITipoLicencia } from '../Models/ITipoLicencia';
import { ITipoDiscapacidad } from '../Models/ITipoDiscapacidad';
import { Candidato } from '../Models/Candidato';


import { Catalogos } from '../Shared/ApiCatalogos';

@Component({
    templateUrl: '/app/Components/alta.candidato.component.html'

})
export class AltaCandidato implements OnInit {
    formDatosGenerales: FormGroup;
    estadosCiviles: any[];
    generos: any[];

    paisesNacimiento: any[];
    estadosNacimiento: any[];
    filteredTiposLicencia: ITipoLicencia[];
    discapacidades: ITipoDiscapacidad[];

    esMexicano: boolean = false;
    esExtrangero: boolean = false;
    wasEdoSelected: boolean = false;
    viveMexico: boolean = false
    edoSelected: boolean = false;
    tieneLicencia: boolean = false;
    discapacitado: boolean = false;
    CP: string;
    slecteditem: any;

    selectedEstadoNacimiento: number = 0;
    FechaNacimiento: Date;
    imgProfile: string='';


    title: String;
    id: number;
    sub: any;

    constructor(
        private fb: FormBuilder, private _catalogosService: CatalogosService,
        private _CandidatosService: CandidatosService, private _Router: Router,
        private _Route: ActivatedRoute, private _ValidatorCURP: CURPValidator,
        private _perfilImageService: PerfilImageService
    ) {
        this.formDatosGenerales = fb.group({
            imgProfileUrl: [''],
            Nombre: ['', Validators.required],
            apellidoPaterno: ['', Validators.required],
            apellidoMaterno: [''],
            email: ['',
                Validators.compose([Validators.required, AltaCandidatoValidator.ValidarCorreo])
            ],
            confirmEmail: ['',
                Validators.compose([Validators.required, AltaCandidatoValidator.ConfirmarCorreo])],

            datospersonales: fb.group({
                paisNacimiento: ['', Validators.required],
                estadoNacimiento: ['', Validators.required],
                municipioNacimiento: [''],
                codigoPostal: [''],
                generoId: ['Genero', Validators.compose([
                    Validators.required, AltaCandidatoValidator.ListaValidator
                ])],
                estadoCivilId: ['Estado Civil'],
                esDiscapacitado: [false],
                tipoDiscapacidadId: ['Clase de Discapacidad'],
                puedeViajar: [false],
                puedeRehubicarse: [false],
                telCelular: [],
                telCasa: [],
                telOficina: [],
                correoElectronico: [true],
                celular: [false],
                whatsApp: [false],
                telLocal: [false],
                fechaNacimiento: [''],
            }),

            direccion: fb.group({
                pais: ['', Validators.required],
                estado: [''],
                municipio: [''],
                codigoPostal: [''],
                colonia: [''],
                calle: [''],
                numeroExterior: [''],
                numeroInterior: ['']
            }),
            identificaciones: fb.group({
                nss: [''],
                curp: ['', Validators.compose([Validators.required])],
                rfc: [''],
                tieneLicenciaConducir: [false],
                tipoLicenciaId: ['Tipo de Licencia']
                //    tieneVehiculo: []
            })

        }/*, { validator: AltaCandidatoValidator.ConfirmarCorreo }*/
        );

    }

    minDate: Date;
    maxDate: Date;
    es: any;
    tr: any;
    invalidDates: Array<Date>

    Candidato: Candidato;
    ngOnInit() {

        this.es = {
            firstDayOfWeek: 1,
            dayNames: ["domingo", "lunes", "martes", "miércoles", "jueves", "viernes", "sábado"],
            dayNamesShort: ["dom", "lun", "mar", "mié", "jue", "vie", "sáb"],
            dayNamesMin: ["D", "L", "M", "X", "J", "V", "S"],
            monthNames: ["enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"],
            monthNamesShort: ["ene", "feb", "mar", "abr", "may", "jun", "jul", "ago", "sep", "oct", "nov", "dic"]
        }

        this.tr = {
            firstDayOfWeek: 1
        }

        let today = new Date();
        let month = today.getMonth();
        let year = today.getFullYear();
        let prevMonth = (month === 0) ? 11 : month - 1;
        let prevYear = (prevMonth === 11) ? year - 1 : year;
        let nextMonth = (month === 11) ? 0 : month + 1;
        let nextYear = (nextMonth === 0) ? year + 1 : year;
        this.minDate = new Date();
        this.minDate.setMonth(prevMonth);
        this.minDate.setFullYear(prevYear);
        this.maxDate = new Date();
        this.maxDate.setMonth(nextMonth);
        this.maxDate.setFullYear(nextYear);

        let invalidDate = new Date();
        invalidDate.setDate(today.getDate() - 1);
        this.invalidDates = [today, invalidDate];
        //-------------------------------------
        this.edoCivilDropdown();
        this.sexosDropdown();


        var parametros = this._Route.params.subscribe(params => {
            this.id = params["id"];
        });
        this.title = this.id ? "Edit Candidato" : "New Candidato";

        if (!this.id)
        {
            this.id = 0;
            return;
        }
            
        this.Candidato == new Candidato();
        this._CandidatosService.GetCandidato(this.id)
            .subscribe(data => {
                this.Candidato = data;
                console.log('de regreso');
                console.log(this.Candidato);
                this.PopulateForm(this.Candidato);
            });

        this.canNavigateToPerfil = true;

        //response => {
        //    if (response.status == 404) {
        //        this._Router.navigate(['not-found'])
        //    }
        //}




        //____________________________________________________________________
    }

    private PopulateForm(candidato: Candidato) {
        if (this.Candidato.direccion.paisId == 42) {
            this.viveMexico = true;
            this.edoSelected = true;
        }
        if (this.Candidato.datospersonales.paisNacimiento.id == 42) {
            this.esMexicano = true;
            this.wasEdoSelected = true;
        }
        if (this.Candidato.identificaciones.tieneLicenciaConducir) {
            this.showTiposLicencias(true);
        }
        this.id = candidato.id;
        this.imgProfile = this.Candidato.imgProfileUrl;
        if (!this.imgProfile) this.imgProfile = '';
        console.log(this.imgProfile);

        this.showTiposDiscapacidades(this.Candidato.datospersonales.esDiscapacitado);

        var fecha = new Date(this.Candidato.datospersonales.fechaNacimiento);
        this.Candidato.datospersonales.fechaNacimiento = fecha;
        this.formDatosGenerales.patchValue({
            imgProfileUrl: this.Candidato.imgProfileUrl,
            Nombre: this.Candidato.nombre,
            apellidoPaterno: this.Candidato.apellidoPaterno,
            apellidoMaterno: this.Candidato.apellidoMaterno,
            email: this.Candidato.email,
            confirmEmail: this.Candidato.email,
            direccion: this.Candidato.direccion,
            identificaciones: this.Candidato.identificaciones,
            datospersonales: this.Candidato.datospersonales,
        });
    }



    filteredCountriesSingle: any[];
    filterCountrySingle(event: any) {
        let query = event.query;
        this._catalogosService.getPaises(Catalogos.PAISES, query).then(countries => {
            this.filteredCountriesSingle = countries;

        });
    }


    idPaisNacimiento: number = 0;
    SetPaisNacimiento(value: any) {
        this.idPaisNacimiento = value.id;
        if (value.id > 0) {
            if (value.pais.toString().toLowerCase() == 'mexico') {
                this.esMexicano = true
                this.direccionNacimientoMexicanoValid = false;
            } else {
                this.esMexicano = false
                this.wasEdoSelected = false;
                this.esExtrangero = true
                this.direccionNacimientoMexicanoValid = true;
            }

            this.paisNacimientoValid = true
        }

    }


    paisNacimientoValid: boolean = false;
    ValidatePaisNacimiento() {
        if (this.idPaisNacimiento == 0) {
            this.paisNacimientoValid = false;
        } else {
            this.paisNacimientoValid = true;
        }

    }

    filteredStatesSingle: any[];

    filterStateSingle(event: any) {
        let query = event.query;
        this._catalogosService.getEstados(Catalogos.ESTADOS, query).then(states => {
            this.filteredStatesSingle = states;

        });
    }

    direccionNacimientoMexicanoValid: boolean = true;
    setEstadoNacimiento(value: any) {
        if (value.id > 0) {
            this.selectedEstadoNacimiento = value.id;
            this.wasEdoSelected = true;
            this.direccionNacimientoMexicanoValid = true;
        }
    }

    ValidateEstadoNacimiento() {
        if (this.selectedEstadoNacimiento == 0) {
            this.wasEdoSelected = false;
        } else {
            this.wasEdoSelected = true;
        }

    }

    filteredTownsSingle: any[];

    filterTownsSingle(event: any) {
        let query = event.query;
        this._catalogosService.getMunicipios(Catalogos.MUNICIPIOS, this.selectedEstadoNacimiento, query).then(towns => {
            this.filteredTownsSingle = towns;

        });
    }

    setMunicipioNacimiento(value: any) {

     
    }


    edoCivilDropdown() {
        this._catalogosService.getEstadosCiviles(Catalogos.ESTADOS_CIVILES)
            .then(edosCiviles => {
                this.estadosCiviles = edosCiviles;
            });
    }

    sexosDropdown() {
        this._catalogosService.getEstadosCiviles(Catalogos.SEXOS).then(generos => {
            this.generos = generos;
        });
    }


    filteredCountries: any[];
    filterCountry(event: any) {
        let query = event.query;
        this._catalogosService.getPaises(Catalogos.PAISES, query).then(countries => {
            this.filteredCountries = countries;

        });
    }

    setPais(value: any) {
        if (value.pais.toString().toLowerCase() == "mexico") {
            this.viveMexico = true
        } else {
            this.viveMexico = false
            this.edoSelected = false;
        }
    }

    filteredStates: any[];
    filterState(event: any) {
        let query = event.query;
        this._catalogosService.getEstados(Catalogos.ESTADOS, query).then(states => {
            this.filteredStates = states;

        });
    }

    setEstado(value: any) {
        this.selectedEstadoNacimiento = value.id;
        this.edoSelected = true;
    }

    filteredTowns: any[];
    filterTowns(event: any) {
        let query = event.query;
        this._catalogosService.getMunicipios(Catalogos.MUNICIPIOS, this.selectedEstadoNacimiento, query).then(towns => {
            this.filteredTowns = towns;

        });
    }

    setMunicipio(value: any) {

        console.log(value);
    }

    filteredColonias: any[];
    filterColonias(event: any) {
        let query = event.query;
        this._catalogosService.getColonia(Catalogos.COLONIAS, this.formDatosGenerales.get('direccion.codigoPostal').value, query).then(colonias => {
            this.filteredColonias = colonias;

        });
    }

    buscarColonias() {
        console.log('buscar colonia');
        console.log(this.formDatosGenerales.get('direccion.codigoPostal').value);
        this._catalogosService.getColonias(Catalogos.COLONIAS, this.formDatosGenerales.get('direccion.codigoPostal').value).
            then(colonias => {
                this.filteredColonias = colonias;
                if (colonias != null) {
                    this.viveMexico = true;
                }

            });


    }

    showTiposLicencias(isChecked: boolean) {
        this.tieneLicencia = isChecked;
        if (isChecked) {
            this._catalogosService.getTiposLicencia(Catalogos.TIPOSLICENCIAS)
                .subscribe(tiposLicencias => {
                    this.filteredTiposLicencia = tiposLicencias;
                });
        }

    }

    showTiposDiscapacidades(isChecked: boolean) {

        this.discapacitado = isChecked;
        if (isChecked) {
            this._catalogosService.getDiscapacidades(Catalogos.DISCAPACIDADES)
                .subscribe(discapacidades => {
                    this.discapacidades = discapacidades;
                })
        }

    }

    telefonoValidate: boolean = false;
    ValidarTelefonos() {
        var celular = this.formDatosGenerales.get('datospersonales.telCelular').value;
        var casa = this.formDatosGenerales.get('datospersonales.telCasa').value;
        var oficina = this.formDatosGenerales.get('datospersonales.telOficina').value;

        if (celular != null && !this.ValidarTelefono(celular)) {
            celular = null;
            this.formDatosGenerales.get('datospersonales.telCelular').setValue(null);

        }
        if (casa != null && !this.ValidarTelefono(casa)) {
            casa = null;
            this.formDatosGenerales.get('datospersonales.telCasa').setValue(null);
        }
        if (oficina != null && !this.ValidarTelefono(oficina)) {
            oficina = null;
            this.formDatosGenerales.get('datospersonales.telOficina').setValue(null);
        }

        if (celular == null && casa == null && oficina == null) {
            this.telefonoValidate = false;
        } else {
            this.telefonoValidate = true;
        }
    }

    ValidarTelefono(telefono: string) {
        if (telefono.trim().length != 10) {
            return false;
        } else {
            return true;
        }


    }

    metodoContacto: boolean = false;
    ValidarMetodoContacto() {
        var email = this.formDatosGenerales.get('datospersonales.correoElectronico').value;
        var celular = this.formDatosGenerales.get('datospersonales.celular').value;
        var whatsapp = this.formDatosGenerales.get('datospersonales.whatsApp').value;
        var telLocal = this.formDatosGenerales.get('datospersonales.telLocal').value;
        if (email == true || celular == true || whatsapp == true || telLocal == true) {
            this.metodoContacto = true;
        }
        else {
            this.metodoContacto = false;
        }
    }
    seguroSocialValido: boolean = true;
    ValidarSeguroSocial() {
        this.seguroSocialValido = true;
        if (this.formDatosGenerales.get('identificaciones.nss').value == null) {
            return;
        }
        var imss = this.formDatosGenerales.get('identificaciones.nss').value;
        if (imss.trim().length != 11) {
            this.formDatosGenerales.get('identificaciones.nss').setValue(null);
            return;
        }
        var isValid = this._ValidatorCURP.ValidarIMSS(
            this.formDatosGenerales.get('datospersonales.fechaNacimiento').value,
            this.formDatosGenerales.get('identificaciones.nss').value
        );
        if (!isValid) {
            this.seguroSocialValido = false;
            this.formDatosGenerales.get('identificaciones.nss').setValue(null);
        } else {
            this.seguroSocialValido = true;
        }
    }

    ClickSeguroSocial() {
        this.seguroSocialValido = false;
    }


    rfcValido: boolean = true;
    ValidarRFC() {
        this.rfcValido = true;
        if (this.formDatosGenerales.get('identificaciones.rfc').value == null) {
            return;
        }
        var rfc = this.formDatosGenerales.get('identificaciones.rfc').value;
        if (rfc.trim().length != 13) {
            this.formDatosGenerales.get('identificaciones.rfc').setValue(null);
            return;
        }
        var isValid = this._ValidatorCURP.ValidarRFC(
            this.formDatosGenerales.get('Nombre').value,
            this.formDatosGenerales.get('apellidoPaterno').value,
            this.formDatosGenerales.get('apellidoMaterno').value,
            this.formDatosGenerales.get('datospersonales.fechaNacimiento').value,
            this.formDatosGenerales.get('datospersonales.generoId').value,
            this.formDatosGenerales.get('datospersonales.estadoNacimiento').value,
            this.formDatosGenerales.get('identificaciones.rfc').value

        );

        if (!isValid) {
            this.rfcValido = false;
            this.formDatosGenerales.get('identificaciones.rfc').setValue(null);
        } else {
            this.rfcValido = true;
        }
    }

    curpValida: boolean = false;
    ValidandoCURP(event: any) {
        console.log(this.formDatosGenerales.get('identificaciones.curp').value);
        if (this.formDatosGenerales.get('identificaciones.curp').value == null) {
            return;
        }
        var curp = this.formDatosGenerales.get('identificaciones.curp').value;
        if (curp.trim().length != 18) {
            this.formDatosGenerales.get('identificaciones.curp').setValue(null);
            return;
        }
        var isValid = this._ValidatorCURP.ValidarCurp(
            this.formDatosGenerales.get('Nombre').value,
            this.formDatosGenerales.get('apellidoPaterno').value,
            this.formDatosGenerales.get('apellidoMaterno').value,
            this.formDatosGenerales.get('datospersonales.fechaNacimiento').value,
            this.formDatosGenerales.get('datospersonales.generoId').value,
            this.formDatosGenerales.get('datospersonales.estadoNacimiento').value,
            this.formDatosGenerales.get('identificaciones.curp').value

        );
        if (!isValid) {
            this.curpValida = true;
        } else {
            this.curpValida = false;
        }
    }

    ClickRFC() {
        this.rfcValido = false;
    }

    KeyUpRFC(value: any) {
        this.rfcValido = false;
    }

    OnLoadedProfileImage(event:any)
    {
        console.log('OnLoadedProfileImage');
        console.log(event);
        this.formDatosGenerales.get('imgProfileUrl').setValue(event);
        if (this.id > 0) {
            this._perfilImageService.SetImageProfileUrl(this.id, event)
                .subscribe(x => {
                    console.log(x);
                });
        }
    }
    canNavigateToPerfil = false;
    Save() {
        var result;
        console.log(this.Candidato);
        console.log(this.formDatosGenerales.value);
        if (this.id) {
            this._CandidatosService.EditCandidato(this.formDatosGenerales.value, this.Candidato.id)
                .subscribe(x => {
                    console.log(x);
                    //this.formDatosGenerales.markAsPristine();
                    this._Router.navigate(['']);

                });
        }
        else {
            this._CandidatosService.AddCandidato(this.formDatosGenerales.value)
                .subscribe(response => {
                    console.log('DENTRO DEL SAVE');
                    this.Candidato = response;
                    console.log(this.Candidato);
                    if (this.Candidato.id > 0)
                        this.canNavigateToPerfil = true;
                    //this.formDatosGenerales.markAsPristine();
                    this._Router.navigate(['PerfilCandidato', this.Candidato.id]);
                });
        }
        console.log(this.formDatosGenerales.value);
    }
}






