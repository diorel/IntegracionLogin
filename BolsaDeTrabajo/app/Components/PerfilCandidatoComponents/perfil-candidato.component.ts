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
            this.title = this.id ? "Edit Perfil" : "New CandidaPerfil";
            console.log('PerfilCandidato params');
            console.log(this.id);

            this.PerfilCandidato = this._fb.group({
                id: [],               
                candidatoId: [this.id],
                aboutme: this._fb.array([]),               
                idiomas: this._fb.array([]),
                Formaciones: this._fb.array([]),
                experiencias: this._fb.array([]),
                cursos: this._fb.array([]),
                conocimientos: this._fb.array([]),
            });

            if (!this.id)
            {
                this.addAboutMe();
                this.addExperiencia();
                this.addFormacion();
                this.addIdioma();               
                this.addCurso();     
                this.addConocimiento()        
                return;
            }
        
        this._perfilCandidatoService.GetPerfilCandidato(this.id)
            .subscribe(data => {
                this.candidatoPerfil = data;
                this.PopulateForm(this.candidatoPerfil);
            });        
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
    }

    initAboutMe() {
        return this._fb.group({
            acercaDeMi: [''],
            puestoDeseado:[''],
            areaExperiencia: [''],
            areaExperienciaId: ['', Validators.compose([
                Validators.required, AltaCandidatoValidator.ListaValidator
            ])],
            perfilExperienciaId: ['Grado de Experiencia', Validators.compose([
                Validators.required, AltaCandidatoValidator.ListaValidator
            ])],
            areaInteresId: ['Área de interes'],
            salarioAceptable: ['', Validators.required],
            salarioDeseado: ['', Validators.required]
        });
    }

    addAboutMe() {
        const control = <FormArray>this.PerfilCandidato.controls['aboutme'];
        const addrCtrl = this.initAboutMe();
        control.push(addrCtrl)
    }

    removeIdioma(i: number) {
        const control = <FormArray>this.PerfilCandidato.controls['idiomas'];
        control.removeAt(i);
    }
    initExperiencia() {
        return this._fb.group({
            empresa: ['', Validators.required],
            giroEmpresaId: ['Giro Empresa', Validators.required],
            cargoAsignado: ['', Validators.required],
            area: [],
            areaId: ['', Validators.required],           
            yearInicioId: ['Año Inicio'],
            monthInicioId: ['Mes Inicio'],
            yearTerminoId: ['Año Termino'],
            monthTerminoId: ['Mes Termino'],
            salario: ['', Validators.required],
            descripcion: [''],
            trabajoActual:[]
        });
    }

    addExperiencia() {
        const control = <FormArray>this.PerfilCandidato.controls['experiencias'];
        const addrCtrl = this.initExperiencia();
        control.push(addrCtrl);
    }

    removeExperiencia(i: number) {
        const control = <FormArray>this.PerfilCandidato.controls['experiencias'];
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
        const control = <FormArray>this.PerfilCandidato.controls['Formaciones'];
        const addrCtrl = this.initFormacion();
        control.push(addrCtrl);
    }

    removeFormacion(i: number) {
        const control = <FormArray>this.PerfilCandidato.controls['Formaciones'];
        control.removeAt(i);
    }
    initCurso() {
        return this._fb.group({
            curso: ['', Validators.required],
            institucionEducativa: [],
            institucionEducativaId: [''],
            yearInicioId: ['Año Inicio'],
            monthInicioId: ['Mes Inicio'],
            yearTerminoId: ['Año Termino'],
            monthTerminoId: ['Mes Termino']
        });
    }

    addCurso() {
        const control = <FormArray>this.PerfilCandidato.controls['cursos'];
        const addrCtrl = this.initCurso();
        control.push(addrCtrl);
    }

    removeCurso(i: number) {
        const control = <FormArray>this.PerfilCandidato.controls['cursos'];
        control.removeAt(i);
    }

    initConocimiento() {
        return this._fb.group({
            conocimiento: ['', Validators.required],
            herramienta: [],
            institucionEducativa: [],
            institucionEducativaId: [''],
            nivelId:['Nivel']
        });
    }

    addConocimiento() {
        const control = <FormArray>this.PerfilCandidato.controls['conocimientos'];
        const addrCtrl = this.initConocimiento();
        control.push(addrCtrl);
    }

    removeConocimiento(i: number) {
        const control = <FormArray>this.PerfilCandidato.controls['conocimientos'];
        control.removeAt(i);
    }
    save(model: any) {
        var result;
        if (this.PerfilCandidato.get('id').value)
        {
            this.EntityAttached();
        }
        console.log('onSave');
        console.log(this.PerfilCandidato.value);
        this._perfilCandidatoService.AddPerfilCandidato(this.id, this.PerfilCandidato.value)
                .subscribe(response => {
                    console.log('DENTRO DEL SAVE');
                    this.candidatoPerfil = response;
                    console.log(this.candidatoPerfil);
                     //this.formDatosGenerales.markAsPristine();
                    this._Router.navigate(['']);
                });
       
        console.log(model);
       
    }
    private EntityAttached() {
        const idiomas = <FormArray>this.PerfilCandidato.controls['idiomas'];
        for (var i = 0; i < idiomas.length; i++) {
            var idioma = idiomas.controls[i];
            idioma.get('idioma').setValue(null);
        }
        const Formaciones = <FormArray>this.PerfilCandidato.controls['Formaciones'];
        for (var i = 0; i < Formaciones.length; i++) {
            var formacion = Formaciones.controls[i];
            formacion.get('carrera').setValue(null);
            formacion.get('institucionEducativa').setValue(null);
        }
        const experiencias = <FormArray>this.PerfilCandidato.controls['experiencias'];
        for (var i = 0; i < experiencias.length; i++) {
            var experiencia = experiencias.controls[i];
            experiencia.get('area').setValue(null);
        }
        const cursos = <FormArray>this.PerfilCandidato.controls['cursos'];
        for (var i = 0; i < cursos.length; i++) {
            var curso = cursos.controls[i];
            curso.get('institucionEducativa').setValue(null);
        }
        const conocimientos = <FormArray>this.PerfilCandidato.controls['conocimientos'];
        for (var i = 0; i < conocimientos.length; i++) {
            var conocimiento = conocimientos.controls[i];
            conocimiento.get('institucionEducativa').setValue(null);
        }
        const aboutme = <FormArray>this.PerfilCandidato.controls['aboutme'];
        for (var i = 0; i < aboutme.length; i++) {
            var about = aboutme.controls[i];
            about.get('areaExperiencia').setValue(null);
        }
   
}
    private PopulateForm(perfilCandidato: PerfilCandidato) {
        var index: number = 1;
        
        if (perfilCandidato==null)
        {
            this.addAboutMe();
            this.addIdioma();
            this.addFormacion();
            this.addExperiencia();
            this.addCurso();
            this.addConocimiento();
            return;
        }
        console.log(perfilCandidato);
        for (let about in perfilCandidato.aboutMe) {
            this.addAboutMe()
        }
        for (let formaion in perfilCandidato.formaciones) {
            this.addFormacion()
        }
        for (let experiencia in perfilCandidato.experiencias) {
            this.addExperiencia()
        }
        for (let curso in perfilCandidato.cursos) {
            this.addCurso()
        }
        for (let idioma in perfilCandidato.idiomas)
        {
            this.addIdioma();
        }
        for (let conocimiento in perfilCandidato.conocimientos) {
            this.addConocimiento()
        }
        this.PerfilCandidato.patchValue({
            id: this.candidatoPerfil.id,
            aboutme: this.candidatoPerfil.aboutMe,
            idiomas: this.candidatoPerfil.idiomas,
            Formaciones: this.candidatoPerfil.formaciones,
            experiencias: this.candidatoPerfil.experiencias,
            cursos: this.candidatoPerfil.cursos,
            conocimientos: this.candidatoPerfil.conocimientos
        });
    }

   
}