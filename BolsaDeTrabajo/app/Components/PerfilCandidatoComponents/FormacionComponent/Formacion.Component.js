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
var PerfilCandidato_Service_1 = require("../../../Services/PerfilCandidato.Service");
var FormacionComponent = (function () {
    function FormacionComponent(fb, _perfilCandidatoService) {
        var _this = this;
        this.fb = fb;
        this._perfilCandidatoService = _perfilCandidatoService;
        this._perfilCandidatoService.GetEstatus()
            .subscribe(function (resp) {
            _this.Estatus = resp;
        });
        this._perfilCandidatoService.GetGradoEstudio()
            .subscribe(function (resp) {
            _this.gradosEstudio = resp;
        });
        this._perfilCandidatoService.GetMonths()
            .subscribe(function (resp) {
            _this.meses = resp;
        });
        this._perfilCandidatoService.GetYears()
            .subscribe(function (resp) {
            _this.years = resp;
        });
        this._perfilCandidatoService.GetDocumentosValidadores()
            .subscribe(function (resp) {
            _this.documentosValidadores = resp;
        });
    }
    FormacionComponent.prototype.filterInstituciones = function (event) {
        var _this = this;
        var query = event.query;
        this._perfilCandidatoService.GetInstituciones(query)
            .then(function (instituciones) {
            _this.filteredInstituciones = instituciones;
        });
    };
    FormacionComponent.prototype.filterCarreras = function (event) {
        var _this = this;
        var query = event.query;
        this._perfilCandidatoService.GetCarreras(query)
            .then(function (carreras) {
            _this.filteredCarreras = carreras;
        });
    };
    FormacionComponent.prototype.SetCarreraId = function (event) {
        this.Formaciones.get('carreraId').setValue(event.id);
        this.Formaciones.get('carrera').setValue(null);
    };
    FormacionComponent.prototype.SetInstitucionId = function (event) {
        this.Formaciones.get('institucionEducativaId').setValue(event.id);
        this.Formaciones.get('institucionEducativa').setValue(null);
    };
    return FormacionComponent;
}());
__decorate([
    core_1.Input('group'),
    __metadata("design:type", forms_1.FormGroup)
], FormacionComponent.prototype, "Formaciones", void 0);
FormacionComponent = __decorate([
    core_1.Component({
        selector: 'Formaciones',
        templateUrl: 'app/Components/PerfilCandidatoComponents/FormacionComponent/Formacion.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder,
        PerfilCandidato_Service_1.PerfilCandidatoService])
], FormacionComponent);
exports.FormacionComponent = FormacionComponent;
//# sourceMappingURL=Formacion.Component.js.map