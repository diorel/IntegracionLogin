"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var router_1 = require("@angular/router");
var alta_candidato_validators_1 = require("./alta.candidato.validators");
var CURP_validator_1 = require("./Validators/CURP.validator");
var catalogos_service_1 = require("../Services/catalogos.service");
var Candidatos_Service_1 = require("../Services/Candidatos.Service");
var ProfileImage_service_1 = require("../Services/ProfileImage.service");
var Candidato_1 = require("../Models/Candidato");
var ApiCatalogos_1 = require("../Shared/ApiCatalogos");
var AltaCandidato = (function () {
    function AltaCandidato(fb, _catalogosService, _CandidatosService, _Router, _Route, _ValidatorCURP, _perfilImageService) {
        this.fb = fb;
        this._catalogosService = _catalogosService;
        this._CandidatosService = _CandidatosService;
        this._Router = _Router;
        this._Route = _Route;
        this._ValidatorCURP = _ValidatorCURP;
        this._perfilImageService = _perfilImageService;
        this.esMexicano = false;
        this.esExtrangero = false;
        this.wasEdoSelected = false;
        this.viveMexico = false;
        this.edoSelected = false;
        this.tieneLicencia = false;
        this.discapacitado = false;
        this.selectedEstadoNacimiento = 0;
        this.imgProfile = '';
        this.idPaisNacimiento = 0;
        this.paisNacimientoValid = false;
        this.direccionNacimientoMexicanoValid = true;
        this.telefonoValidate = false;
        this.metodoContacto = false;
        this.seguroSocialValido = true;
        this.rfcValido = true;
        this.curpValida = false;
        this.canNavigateToPerfil = false;
        this.formDatosGenerales = fb.group({
            imgProfileUrl: [''],
            Nombre: ['', forms_1.Validators.required],
            apellidoPaterno: ['', forms_1.Validators.required],
            apellidoMaterno: [''],
            email: ['',
                forms_1.Validators.compose([forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ValidarCorreo])
            ],
            confirmEmail: ['',
                forms_1.Validators.compose([forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ConfirmarCorreo])],
            datospersonales: fb.group({
                paisNacimiento: ['', forms_1.Validators.required],
                estadoNacimiento: ['', forms_1.Validators.required],
                municipioNacimiento: [''],
                codigoPostal: [''],
                generoId: ['Genero', forms_1.Validators.compose([
                        forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ListaValidator
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
                pais: ['', forms_1.Validators.required],
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
                curp: ['', forms_1.Validators.compose([forms_1.Validators.required])],
                rfc: [''],
                tieneLicenciaConducir: [false],
                tipoLicenciaId: ['Tipo de Licencia']
                //    tieneVehiculo: []
            })
        } /*, { validator: AltaCandidatoValidator.ConfirmarCorreo }*/);
    }
    AltaCandidato.prototype.ngOnInit = function () {
        var _this = this;
        this.es = {
            firstDayOfWeek: 1,
            dayNames: ["domingo", "lunes", "martes", "miércoles", "jueves", "viernes", "sábado"],
            dayNamesShort: ["dom", "lun", "mar", "mié", "jue", "vie", "sáb"],
            dayNamesMin: ["D", "L", "M", "X", "J", "V", "S"],
            monthNames: ["enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"],
            monthNamesShort: ["ene", "feb", "mar", "abr", "may", "jun", "jul", "ago", "sep", "oct", "nov", "dic"]
        };
        this.tr = {
            firstDayOfWeek: 1
        };
        var today = new Date();
        var month = today.getMonth();
        var year = today.getFullYear();
        var prevMonth = (month === 0) ? 11 : month - 1;
        var prevYear = (prevMonth === 11) ? year - 1 : year;
        var nextMonth = (month === 11) ? 0 : month + 1;
        var nextYear = (nextMonth === 0) ? year + 1 : year;
        this.minDate = new Date();
        this.minDate.setMonth(prevMonth);
        this.minDate.setFullYear(prevYear);
        this.maxDate = new Date();
        this.maxDate.setMonth(nextMonth);
        this.maxDate.setFullYear(nextYear);
        var invalidDate = new Date();
        invalidDate.setDate(today.getDate() - 1);
        this.invalidDates = [today, invalidDate];
        //-------------------------------------
        this.edoCivilDropdown();
        this.sexosDropdown();
        var parametros = this._Route.params.subscribe(function (params) {
            _this.id = params["id"];
        });
        this.title = this.id ? "Edit Candidato" : "New Candidato";
        if (!this.id) {
            this.id = 0;
            return;
        }
        this.Candidato == new Candidato_1.Candidato();
        this._CandidatosService.GetCandidato(this.id)
            .subscribe(function (data) {
            _this.Candidato = data;
            console.log('de regreso');
            console.log(_this.Candidato);
            _this.PopulateForm(_this.Candidato);
        });
        this.canNavigateToPerfil = true;
        //response => {
        //    if (response.status == 404) {
        //        this._Router.navigate(['not-found'])
        //    }
        //}
        //____________________________________________________________________
    };
    AltaCandidato.prototype.PopulateForm = function (candidato) {
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
        if (!this.imgProfile)
            this.imgProfile = '';
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
    };
    AltaCandidato.prototype.filterCountrySingle = function (event) {
        var _this = this;
        var query = event.query;
        this._catalogosService.getPaises(ApiCatalogos_1.Catalogos.PAISES, query).then(function (countries) {
            _this.filteredCountriesSingle = countries;
        });
    };
    AltaCandidato.prototype.SetPaisNacimiento = function (value) {
        this.idPaisNacimiento = value.id;
        if (value.id > 0) {
            if (value.pais.toString().toLowerCase() == 'mexico') {
                this.esMexicano = true;
                this.direccionNacimientoMexicanoValid = false;
            }
            else {
                this.esMexicano = false;
                this.wasEdoSelected = false;
                this.esExtrangero = true;
                this.direccionNacimientoMexicanoValid = true;
            }
            this.paisNacimientoValid = true;
        }
    };
    AltaCandidato.prototype.ValidatePaisNacimiento = function () {
        if (this.idPaisNacimiento == 0) {
            this.paisNacimientoValid = false;
        }
        else {
            this.paisNacimientoValid = true;
        }
    };
    AltaCandidato.prototype.filterStateSingle = function (event) {
        var _this = this;
        var query = event.query;
        this._catalogosService.getEstados(ApiCatalogos_1.Catalogos.ESTADOS, query).then(function (states) {
            _this.filteredStatesSingle = states;
        });
    };
    AltaCandidato.prototype.setEstadoNacimiento = function (value) {
        if (value.id > 0) {
            this.selectedEstadoNacimiento = value.id;
            this.wasEdoSelected = true;
            this.direccionNacimientoMexicanoValid = true;
        }
    };
    AltaCandidato.prototype.ValidateEstadoNacimiento = function () {
        if (this.selectedEstadoNacimiento == 0) {
            this.wasEdoSelected = false;
        }
        else {
            this.wasEdoSelected = true;
        }
    };
    AltaCandidato.prototype.filterTownsSingle = function (event) {
        var _this = this;
        var query = event.query;
        this._catalogosService.getMunicipios(ApiCatalogos_1.Catalogos.MUNICIPIOS, this.selectedEstadoNacimiento, query).then(function (towns) {
            _this.filteredTownsSingle = towns;
        });
    };
    AltaCandidato.prototype.setMunicipioNacimiento = function (value) {
    };
    AltaCandidato.prototype.edoCivilDropdown = function () {
        var _this = this;
        this._catalogosService.getEstadosCiviles(ApiCatalogos_1.Catalogos.ESTADOS_CIVILES)
            .then(function (edosCiviles) {
            _this.estadosCiviles = edosCiviles;
        });
    };
    AltaCandidato.prototype.sexosDropdown = function () {
        var _this = this;
        this._catalogosService.getEstadosCiviles(ApiCatalogos_1.Catalogos.SEXOS).then(function (generos) {
            _this.generos = generos;
        });
    };
    AltaCandidato.prototype.filterCountry = function (event) {
        var _this = this;
        var query = event.query;
        this._catalogosService.getPaises(ApiCatalogos_1.Catalogos.PAISES, query).then(function (countries) {
            _this.filteredCountries = countries;
        });
    };
    AltaCandidato.prototype.setPais = function (value) {
        if (value.pais.toString().toLowerCase() == "mexico") {
            this.viveMexico = true;
        }
        else {
            this.viveMexico = false;
            this.edoSelected = false;
        }
    };
    AltaCandidato.prototype.filterState = function (event) {
        var _this = this;
        var query = event.query;
        this._catalogosService.getEstados(ApiCatalogos_1.Catalogos.ESTADOS, query).then(function (states) {
            _this.filteredStates = states;
        });
    };
    AltaCandidato.prototype.setEstado = function (value) {
        this.selectedEstadoNacimiento = value.id;
        this.edoSelected = true;
    };
    AltaCandidato.prototype.filterTowns = function (event) {
        var _this = this;
        var query = event.query;
        this._catalogosService.getMunicipios(ApiCatalogos_1.Catalogos.MUNICIPIOS, this.selectedEstadoNacimiento, query).then(function (towns) {
            _this.filteredTowns = towns;
        });
    };
    AltaCandidato.prototype.setMunicipio = function (value) {
        console.log(value);
    };
    AltaCandidato.prototype.filterColonias = function (event) {
        var _this = this;
        var query = event.query;
        this._catalogosService.getColonia(ApiCatalogos_1.Catalogos.COLONIAS, this.formDatosGenerales.get('direccion.codigoPostal').value, query).then(function (colonias) {
            _this.filteredColonias = colonias;
        });
    };
    AltaCandidato.prototype.buscarColonias = function () {
        var _this = this;
        console.log('buscar colonia');
        console.log(this.formDatosGenerales.get('direccion.codigoPostal').value);
        this._catalogosService.getColonias(ApiCatalogos_1.Catalogos.COLONIAS, this.formDatosGenerales.get('direccion.codigoPostal').value).
            then(function (colonias) {
            _this.filteredColonias = colonias;
            if (colonias != null) {
                _this.viveMexico = true;
            }
        });
    };
    AltaCandidato.prototype.showTiposLicencias = function (isChecked) {
        var _this = this;
        this.tieneLicencia = isChecked;
        if (isChecked) {
            this._catalogosService.getTiposLicencia(ApiCatalogos_1.Catalogos.TIPOSLICENCIAS)
                .subscribe(function (tiposLicencias) {
                _this.filteredTiposLicencia = tiposLicencias;
            });
        }
    };
    AltaCandidato.prototype.showTiposDiscapacidades = function (isChecked) {
        var _this = this;
        this.discapacitado = isChecked;
        if (isChecked) {
            this._catalogosService.getDiscapacidades(ApiCatalogos_1.Catalogos.DISCAPACIDADES)
                .subscribe(function (discapacidades) {
                _this.discapacidades = discapacidades;
            });
        }
    };
    AltaCandidato.prototype.ValidarTelefonos = function () {
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
        }
        else {
            this.telefonoValidate = true;
        }
    };
    AltaCandidato.prototype.ValidarTelefono = function (telefono) {
        if (telefono.trim().length != 10) {
            return false;
        }
        else {
            return true;
        }
    };
    AltaCandidato.prototype.ValidarMetodoContacto = function () {
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
    };
    AltaCandidato.prototype.ValidarSeguroSocial = function () {
        this.seguroSocialValido = true;
        if (this.formDatosGenerales.get('identificaciones.nss').value == null) {
            return;
        }
        var imss = this.formDatosGenerales.get('identificaciones.nss').value;
        if (imss.trim().length != 11) {
            this.formDatosGenerales.get('identificaciones.nss').setValue(null);
            return;
        }
        var isValid = this._ValidatorCURP.ValidarIMSS(this.formDatosGenerales.get('datospersonales.fechaNacimiento').value, this.formDatosGenerales.get('identificaciones.nss').value);
        if (!isValid) {
            this.seguroSocialValido = false;
            this.formDatosGenerales.get('identificaciones.nss').setValue(null);
        }
        else {
            this.seguroSocialValido = true;
        }
    };
    AltaCandidato.prototype.ClickSeguroSocial = function () {
        this.seguroSocialValido = false;
    };
    AltaCandidato.prototype.ValidarRFC = function () {
        this.rfcValido = true;
        if (this.formDatosGenerales.get('identificaciones.rfc').value == null) {
            return;
        }
        var rfc = this.formDatosGenerales.get('identificaciones.rfc').value;
        if (rfc.trim().length != 13) {
            this.formDatosGenerales.get('identificaciones.rfc').setValue(null);
            return;
        }
        var isValid = this._ValidatorCURP.ValidarRFC(this.formDatosGenerales.get('Nombre').value, this.formDatosGenerales.get('apellidoPaterno').value, this.formDatosGenerales.get('apellidoMaterno').value, this.formDatosGenerales.get('datospersonales.fechaNacimiento').value, this.formDatosGenerales.get('datospersonales.generoId').value, this.formDatosGenerales.get('datospersonales.estadoNacimiento').value, this.formDatosGenerales.get('identificaciones.rfc').value);
        if (!isValid) {
            this.rfcValido = false;
            this.formDatosGenerales.get('identificaciones.rfc').setValue(null);
        }
        else {
            this.rfcValido = true;
        }
    };
    AltaCandidato.prototype.ValidandoCURP = function (event) {
        console.log(this.formDatosGenerales.get('identificaciones.curp').value);
        if (this.formDatosGenerales.get('identificaciones.curp').value == null) {
            return;
        }
        var curp = this.formDatosGenerales.get('identificaciones.curp').value;
        if (curp.trim().length != 18) {
            this.formDatosGenerales.get('identificaciones.curp').setValue(null);
            return;
        }
        var isValid = this._ValidatorCURP.ValidarCurp(this.formDatosGenerales.get('Nombre').value, this.formDatosGenerales.get('apellidoPaterno').value, this.formDatosGenerales.get('apellidoMaterno').value, this.formDatosGenerales.get('datospersonales.fechaNacimiento').value, this.formDatosGenerales.get('datospersonales.generoId').value, this.formDatosGenerales.get('datospersonales.estadoNacimiento').value, this.formDatosGenerales.get('identificaciones.curp').value);
        if (!isValid) {
            this.curpValida = true;
        }
        else {
            this.curpValida = false;
        }
    };
    AltaCandidato.prototype.ClickRFC = function () {
        this.rfcValido = false;
    };
    AltaCandidato.prototype.KeyUpRFC = function (value) {
        this.rfcValido = false;
    };
    AltaCandidato.prototype.OnLoadedProfileImage = function (event) {
        console.log('OnLoadedProfileImage');
        console.log(event);
        this.formDatosGenerales.get('imgProfileUrl').setValue(event);
        if (this.id > 0) {
            this._perfilImageService.SetImageProfileUrl(this.id, event)
                .subscribe(function (x) {
                console.log(x);
            });
        }
    };
    AltaCandidato.prototype.Save = function () {
        var _this = this;
        var result;
        console.log(this.Candidato);
        console.log(this.formDatosGenerales.value);
        if (this.id) {
            this._CandidatosService.EditCandidato(this.formDatosGenerales.value, this.Candidato.id)
                .subscribe(function (x) {
                console.log(x);
                //this.formDatosGenerales.markAsPristine();
                _this._Router.navigate(['']);
            });
        }
        else {
            this._CandidatosService.AddCandidato(this.formDatosGenerales.value)
                .subscribe(function (response) {
                console.log('DENTRO DEL SAVE');
                _this.Candidato = response;
                console.log(_this.Candidato);
                if (_this.Candidato.id > 0)
                    _this.canNavigateToPerfil = true;
                //this.formDatosGenerales.markAsPristine();
                _this._Router.navigate(['PerfilCandidato', _this.Candidato.id]);
            });
        }
        console.log(this.formDatosGenerales.value);
    };
    return AltaCandidato;
}());
AltaCandidato = __decorate([
    core_1.Component({
        templateUrl: '/app/Components/alta.candidato.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder, catalogos_service_1.CatalogosService,
        Candidatos_Service_1.CandidatosService, router_1.Router,
        router_1.ActivatedRoute, CURP_validator_1.CURPValidator,
        ProfileImage_service_1.PerfilImageService])
], AltaCandidato);
exports.AltaCandidato = AltaCandidato;
//# sourceMappingURL=alta.candidato.component.js.map