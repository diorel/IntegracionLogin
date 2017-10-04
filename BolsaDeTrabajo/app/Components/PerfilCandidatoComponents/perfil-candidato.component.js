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
        this.title = this.id ? "Edit Perfil" : "New CandidaPerfilto";
        console.log('PerfilCandidato params');
        console.log(this.id);
        this.PerfilCandidato = this._fb.group({
            id: [],
            candidatoId: [this.id],
            idiomas: this._fb.array([]),
            formaciones: this._fb.array([])
        });
        if (!this.id) {
            this.addIdioma();
            this.addFormacion();
            return;
        }
        this._perfilCandidatoService.GetPerfilCandidato(this.id)
            .subscribe(function (data) {
            _this.candidatoPerfil = data;
            _this.PopulateForm(_this.candidatoPerfil);
        });
        // add address
        /* subscribe to addresses value changes */
        // this.myForm.controls['addresses'].valueChanges.subscribe(x => {
        //   console.log(x);
        // })
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
        /* subscribe to individual address value changes */
        // addrCtrl.valueChanges.subscribe(x => {
        //   console.log(x);
        // })
    };
    CandidatoPerfil.prototype.removeIdioma = function (i) {
        var control = this.PerfilCandidato.controls['idiomas'];
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
        //const control = <FormArray>this.PerfilCandidato.controls['idiomas'];
        var control = this.PerfilCandidato.controls['formaciones'];
        var addrCtrl = this.initFormacion();
        control.push(addrCtrl);
        /* subscribe to individual address value changes */
        // addrCtrl.valueChanges.subscribe(x => {
        //   console.log(x);
        // })
    };
    CandidatoPerfil.prototype.removeFormacion = function (i) {
        var control = this.PerfilCandidato.controls['formaciones'];
        control.removeAt(i);
    };
    CandidatoPerfil.prototype.save = function (model) {
        var _this = this;
        // call API to save
        // ...
        var result;
        this._perfilCandidatoService.AddPerfilCandidato(this.id, this.PerfilCandidato.value)
            .subscribe(function (response) {
            console.log('DENTRO DEL SAVE');
            _this.candidatoPerfil = response;
            console.log(_this.candidatoPerfil);
            //this.formDatosGenerales.markAsPristine();
            _this._Router.navigate(['']);
        });
        console.log(model);
        console.log('onSave');
        console.log(this.PerfilCandidato.value);
    };
    CandidatoPerfil.prototype.PopulateForm = function (perfilCandidato) {
        var index = 1;
        if (perfilCandidato == null) {
            this.addIdioma();
            this.addFormacion();
            return;
        }
        if (perfilCandidato.formaciones.length == 0) {
            this.addFormacion();
            return;
        }
        if (perfilCandidato.idiomas.length == 0) {
            this.addIdioma();
            return;
        }
        for (var formaion in perfilCandidato.formaciones) {
            this.addFormacion();
        }
        for (var idioma in perfilCandidato.idiomas) {
            this.addIdioma();
        }
        this.PerfilCandidato.patchValue({
            id: this.candidatoPerfil.id,
            idiomas: this.candidatoPerfil.idiomas,
            formaciones: this.candidatoPerfil.formaciones,
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