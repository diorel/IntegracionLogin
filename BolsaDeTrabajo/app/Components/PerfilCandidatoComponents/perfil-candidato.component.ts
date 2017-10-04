import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl, FormArray, FormBuilder, Validators } from '@angular/forms';
import { PerfilCandidatoService } from '../../Services/PerfilCandidato.Service';
import { PerfilCandidato, Formacion } from '../../Models/PerfilCandidato';
import { AltaCandidatoValidator } from '../alta.candidato.validators';

@Component({
    templateUrl: 'app/Components/PerfilCandidatoComponents/Perfil-Candidato.component.html'
})
export class CandidatoPerfil {
    public PerfilCandidato: FormGroup;
    private id: number = 0;
    private candidatoPerfil: PerfilCandidato;
    private title: string;
    constructor(private _fb: FormBuilder,
        private _Router: Router,
        private _Route: ActivatedRoute,
        private _perfilCandidatoService: PerfilCandidatoService) { }

    ngOnInit() {   

       var parametros = this._Route.params.subscribe(params => {
           this.id = params["id"];           
            });
            this.title = this.id ? "Edit Perfil" : "New CandidaPerfilto";
            console.log('PerfilCandidato params');
            console.log(this.id);

            this.PerfilCandidato = this._fb.group({
                id: [],
                candidatoId: [this.id],
                idiomas: this._fb.array([]),
                formaciones: this._fb.array([])
            });

            if (!this.id)
            {
                this.addIdioma();
                this.addFormacion();                
                return;
            }
        
        this._perfilCandidatoService.GetPerfilCandidato(this.id)
            .subscribe(data => {
                this.candidatoPerfil = data;
                this.PopulateForm(this.candidatoPerfil);
            });
        

        // add address
       
        /* subscribe to addresses value changes */
        // this.myForm.controls['addresses'].valueChanges.subscribe(x => {
        //   console.log(x);
        // })
    }
   

    initIdioma() {
        return this._fb.group({          
            idioma: [],
            idiomaId: ['', Validators.required],
            nivelId: ['Nivel', Validators.compose([
                Validators.required, AltaCandidatoValidator.ListaValidator
            ])]
        });
    }

    addIdioma() {
        //const control = <FormArray>this.PerfilCandidato.controls['idiomas'];
        const control = <FormArray>this.PerfilCandidato.controls['idiomas'];
        const addrCtrl = this.initIdioma();
        control.push(addrCtrl);

        /* subscribe to individual address value changes */
        // addrCtrl.valueChanges.subscribe(x => {
        //   console.log(x);
        // })
    }

    removeIdioma(i: number) {
        const control = <FormArray>this.PerfilCandidato.controls['idiomas'];
        control.removeAt(i);
    }

    initFormacion() {
        return this._fb.group({
            institucionEducativa: [],
            institucionEducativaId: ['', Validators.required],
            gradoEstudiosId: ['Nivel de Estudios', Validators.compose([
                Validators.required, AltaCandidatoValidator.ListaValidator
            ])],
            estadoEstudioId: ['Estatus', Validators.compose([
                Validators.required, AltaCandidatoValidator.ListaValidator
            ])],
            documentoValidadorId: ['Documento Validador'],
            carrera: [],
            carreraId:[],
            yearInicioId: ['Año Inicio'],
            monthInicioId: ['Mes Inicio'],
            yearTerminoId: ['Año Termino'],
            monthTerminoId: ['Mes Termino']
        });
    }

    addFormacion() {
        //const control = <FormArray>this.PerfilCandidato.controls['idiomas'];
        const control = <FormArray>this.PerfilCandidato.controls['formaciones'];
        const addrCtrl = this.initFormacion();
        control.push(addrCtrl);

        /* subscribe to individual address value changes */
        // addrCtrl.valueChanges.subscribe(x => {
        //   console.log(x);
        // })
    }

    removeFormacion(i: number) {
        const control = <FormArray>this.PerfilCandidato.controls['formaciones'];
        control.removeAt(i);
    }

    save(model: any) {
        // call API to save
        // ...
        var result;

        this._perfilCandidatoService.AddPerfilCandidato(this.id, this.PerfilCandidato.value)
                .subscribe(response => {
                    console.log('DENTRO DEL SAVE');
                    this.candidatoPerfil = response;
                    console.log(this.candidatoPerfil);
                     //this.formDatosGenerales.markAsPristine();
                    this._Router.navigate(['']);
                });
       
        console.log(model);
        console.log('onSave');
        console.log(this.PerfilCandidato.value);
    }

    private PopulateForm(perfilCandidato: PerfilCandidato) {
        var index: number = 1;
        
        if (perfilCandidato==null)
        {
            this.addIdioma();
            this.addFormacion();
            return;
        }
        if (perfilCandidato.formaciones.length == 0 ) {
             this.addFormacion();
            return;
        }
        if (perfilCandidato.idiomas.length == 0) {
            this.addIdioma();
            return;
        }
        for (let formaion in perfilCandidato.formaciones) {
            this.addFormacion()
        }
        for (let idioma in perfilCandidato.idiomas)
        {
            this.addIdioma();
        }
        
        this.PerfilCandidato.patchValue({
            id: this.candidatoPerfil.id,
            idiomas: this.candidatoPerfil.idiomas,
            formaciones: this.candidatoPerfil.formaciones,
        });
    }

   
}