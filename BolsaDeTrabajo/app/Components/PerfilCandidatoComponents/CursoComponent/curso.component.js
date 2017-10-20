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
var CursoComponent = (function () {
    function CursoComponent(fb, _perfilCandidatoService) {
        var _this = this;
        this.fb = fb;
        this._perfilCandidatoService = _perfilCandidatoService;
        this._perfilCandidatoService.GetMonths()
            .subscribe(function (resp) {
            _this.meses = resp;
        });
        this._perfilCandidatoService.GetYears()
            .subscribe(function (resp) {
            _this.years = resp;
        });
    }
    CursoComponent.prototype.filterInstituciones = function (event) {
        var _this = this;
        var query = event.query;
        this._perfilCandidatoService.GetInstituciones(query)
            .then(function (instituciones) {
            _this.filteredInstituciones = instituciones;
        });
    };
    CursoComponent.prototype.SetInstitucionId = function (event) {
        this.Cursos.get('institucionEducativaId').setValue(event.id);
        this.Cursos.get('institucionEducativa').setValue(null);
    };
    return CursoComponent;
}());
__decorate([
    core_1.Input('group'),
    __metadata("design:type", forms_1.FormGroup)
], CursoComponent.prototype, "Cursos", void 0);
CursoComponent = __decorate([
    core_1.Component({
        selector: 'cursos',
        templateUrl: 'app/Components/PerfilCandidatoComponents/CursoComponent/curso.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder,
        PerfilCandidato_Service_1.PerfilCandidatoService])
], CursoComponent);
exports.CursoComponent = CursoComponent;
//# sourceMappingURL=curso.component.js.map