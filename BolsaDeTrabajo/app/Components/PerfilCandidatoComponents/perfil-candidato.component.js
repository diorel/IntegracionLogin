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
var router_1 = require("@angular/router");
var forms_1 = require("@angular/forms");
var PerfilCandidato_Service_1 = require("../../Services/PerfilCandidato.Service");
var alta_candidato_validators_1 = require("../alta.candidato.validators");
var CandidatoPerfil = (function () {
    function CandidatoPerfil(_fb, _Router, _Route, _perfilCandidatoService) {
        this._fb = _fb;
        this._Router = _Router;
        this._Route = _Route;
        this._perfilCandidatoService = _perfilCandidatoService;
        this.id = 0;
    }
    CandidatoPerfil.prototype.ngOnInit = function () {
        var _this = this;
        var parametros = this._Route.params.subscribe(function (params) {
            _this.id = params["id"];
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
        if (!this.id) {
            this.addAboutMe();
            this.addExperiencia();
            this.addFormacion();
            this.addIdioma();
            this.addCurso();
            this.addConocimiento();
            return;
        }
        this._perfilCandidatoService.GetPerfilCandidato(this.id)
            .subscribe(function (data) {
            _this.candidatoPerfil = data;
            _this.PopulateForm(_this.candidatoPerfil);
        });
    };
    CandidatoPerfil.prototype.initIdioma = function () {
        return this._fb.group({
            idioma: [],
            idiomaId: ['', forms_1.Validators.required],
            nivelId: ['Nivel', forms_1.Validators.compose([
                    forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ListaValidator
                ])]
        });
    };
    CandidatoPerfil.prototype.addIdioma = function () {
        //const control = <FormArray>this.PerfilCandidato.controls['idiomas'];
        var control = this.PerfilCandidato.controls['idiomas'];
        var addrCtrl = this.initIdioma();
        control.push(addrCtrl);
    };
    CandidatoPerfil.prototype.initAboutMe = function () {
        return this._fb.group({
            acercaDeMi: [''],
            puestoDeseado: [''],
            areaExperiencia: [''],
            areaExperienciaId: ['', forms_1.Validators.compose([
                    forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ListaValidator
                ])],
            perfilExperienciaId: ['Grado de Experiencia', forms_1.Validators.compose([
                    forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ListaValidator
                ])],
            areaInteresId: ['Área de interes'],
            salarioAceptable: ['', forms_1.Validators.required],
            salarioDeseado: ['', forms_1.Validators.required]
        });
    };
    CandidatoPerfil.prototype.addAboutMe = function () {
        var control = this.PerfilCandidato.controls['aboutme'];
        var addrCtrl = this.initAboutMe();
        control.push(addrCtrl);
    };
    CandidatoPerfil.prototype.removeIdioma = function (i) {
        var control = this.PerfilCandidato.controls['idiomas'];
        control.removeAt(i);
    };
    CandidatoPerfil.prototype.initExperiencia = function () {
        return this._fb.group({
            empresa: ['', forms_1.Validators.required],
            giroEmpresaId: ['Giro Empresa', forms_1.Validators.required],
            cargoAsignado: ['', forms_1.Validators.required],
            area: [],
            areaId: ['', forms_1.Validators.required],
            yearInicioId: ['Año Inicio'],
            monthInicioId: ['Mes Inicio'],
            yearTerminoId: ['Año Termino'],
            monthTerminoId: ['Mes Termino'],
            salario: ['', forms_1.Validators.required],
            descripcion: [''],
            trabajoActual: []
        });
    };
    CandidatoPerfil.prototype.addExperiencia = function () {
        var control = this.PerfilCandidato.controls['experiencias'];
        var addrCtrl = this.initExperiencia();
        control.push(addrCtrl);
    };
    CandidatoPerfil.prototype.removeExperiencia = function (i) {
        var control = this.PerfilCandidato.controls['experiencias'];
        control.removeAt(i);
    };
    CandidatoPerfil.prototype.initFormacion = function () {
        return this._fb.group({
            institucionEducativa: [],
            institucionEducativaId: ['', forms_1.Validators.required],
            gradoEstudiosId: ['Nivel de Estudios', forms_1.Validators.compose([
                    forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ListaValidator
                ])],
            estadoEstudioId: ['Estatus', forms_1.Validators.compose([
                    forms_1.Validators.required, alta_candidato_validators_1.AltaCandidatoValidator.ListaValidator
                ])],
            documentoValidadorId: ['Documento Validador'],
            carrera: [],
            carreraId: [],
            yearInicioId: ['Año Inicio'],
            monthInicioId: ['Mes Inicio'],
            yearTerminoId: ['Año Termino'],
            monthTerminoId: ['Mes Termino']
        });
    };
    CandidatoPerfil.prototype.addFormacion = function () {
        var control = this.PerfilCandidato.controls['Formaciones'];
        var addrCtrl = this.initFormacion();
        control.push(addrCtrl);
    };
    CandidatoPerfil.prototype.removeFormacion = function (i) {
        var control = this.PerfilCandidato.controls['Formaciones'];
        control.removeAt(i);
    };
    CandidatoPerfil.prototype.initCurso = function () {
        return this._fb.group({
            curso: ['', forms_1.Validators.required],
            institucionEducativa: [],
            institucionEducativaId: [''],
            yearInicioId: ['Año Inicio'],
            monthInicioId: ['Mes Inicio'],
            yearTerminoId: ['Año Termino'],
            monthTerminoId: ['Mes Termino']
        });
    };
    CandidatoPerfil.prototype.addCurso = function () {
        var control = this.PerfilCandidato.controls['cursos'];
        var addrCtrl = this.initCurso();
        control.push(addrCtrl);
    };
    CandidatoPerfil.prototype.removeCurso = function (i) {
        var control = this.PerfilCandidato.controls['cursos'];
        control.removeAt(i);
    };
    CandidatoPerfil.prototype.initConocimiento = function () {
        return this._fb.group({
            conocimiento: ['', forms_1.Validators.required],
            herramienta: [],
            institucionEducativa: [],
            institucionEducativaId: [''],
            nivelId: ['Nivel']
        });
    };
    CandidatoPerfil.prototype.addConocimiento = function () {
        var control = this.PerfilCandidato.controls['conocimientos'];
        var addrCtrl = this.initConocimiento();
        control.push(addrCtrl);
    };
    CandidatoPerfil.prototype.removeConocimiento = function (i) {
        var control = this.PerfilCandidato.controls['conocimientos'];
        control.removeAt(i);
    };
    CandidatoPerfil.prototype.save = function (model) {
        var _this = this;
        var result;
        if (this.PerfilCandidato.get('id').value) {
            this.EntityAttached();
        }
        console.log('onSave');
        console.log(this.PerfilCandidato.value);
        this._perfilCandidatoService.AddPerfilCandidato(this.id, this.PerfilCandidato.value)
            .subscribe(function (response) {
            console.log('DENTRO DEL SAVE');
            _this.candidatoPerfil = response;
            console.log(_this.candidatoPerfil);
            //this.formDatosGenerales.markAsPristine();
            _this._Router.navigate(['']);
        });
        console.log(model);
    };
    CandidatoPerfil.prototype.EntityAttached = function () {
        var idiomas = this.PerfilCandidato.controls['idiomas'];
        for (var i = 0; i < idiomas.length; i++) {
            var idioma = idiomas.controls[i];
            idioma.get('idioma').setValue(null);
        }
        var Formaciones = this.PerfilCandidato.controls['Formaciones'];
        for (var i = 0; i < Formaciones.length; i++) {
            var formacion = Formaciones.controls[i];
            formacion.get('carrera').setValue(null);
            formacion.get('institucionEducativa').setValue(null);
        }
        var experiencias = this.PerfilCandidato.controls['experiencias'];
        for (var i = 0; i < experiencias.length; i++) {
            var experiencia = experiencias.controls[i];
            experiencia.get('area').setValue(null);
        }
        var cursos = this.PerfilCandidato.controls['cursos'];
        for (var i = 0; i < cursos.length; i++) {
            var curso = cursos.controls[i];
            curso.get('institucionEducativa').setValue(null);
        }
        var conocimientos = this.PerfilCandidato.controls['conocimientos'];
        for (var i = 0; i < conocimientos.length; i++) {
            var conocimiento = conocimientos.controls[i];
            conocimiento.get('institucionEducativa').setValue(null);
        }
        var aboutme = this.PerfilCandidato.controls['aboutme'];
        for (var i = 0; i < aboutme.length; i++) {
            var about = aboutme.controls[i];
            about.get('areaExperiencia').setValue(null);
        }
    };
    CandidatoPerfil.prototype.PopulateForm = function (perfilCandidato) {
        var index = 1;
        if (perfilCandidato == null) {
            this.addAboutMe();
            this.addIdioma();
            this.addFormacion();
            this.addExperiencia();
            this.addCurso();
            this.addConocimiento();
            return;
        }
        console.log(perfilCandidato);
        for (var about in perfilCandidato.aboutMe) {
            this.addAboutMe();
        }
        for (var formaion in perfilCandidato.formaciones) {
            this.addFormacion();
        }
        for (var experiencia in perfilCandidato.experiencias) {
            this.addExperiencia();
        }
        for (var curso in perfilCandidato.cursos) {
            this.addCurso();
        }
        for (var idioma in perfilCandidato.idiomas) {
            this.addIdioma();
        }
        for (var conocimiento in perfilCandidato.conocimientos) {
            this.addConocimiento();
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
    };
    return CandidatoPerfil;
}());
CandidatoPerfil = __decorate([
    core_1.Component({
        templateUrl: 'app/Components/PerfilCandidatoComponents/Perfil-Candidato.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder,
        router_1.Router,
        router_1.ActivatedRoute,
        PerfilCandidato_Service_1.PerfilCandidatoService])
], CandidatoPerfil);
exports.CandidatoPerfil = CandidatoPerfil;
//# sourceMappingURL=perfil-candidato.component.js.map