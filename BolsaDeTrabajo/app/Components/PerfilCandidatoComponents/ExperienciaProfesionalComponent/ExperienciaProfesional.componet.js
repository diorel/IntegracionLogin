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
var ExperienciaProfesionalComponent = (function () {
    function ExperienciaProfesionalComponent(fb, _perfilCandidatoService) {
        var _this = this;
        this.fb = fb;
        this._perfilCandidatoService = _perfilCandidatoService;
        this._perfilCandidatoService.GetGirosEmpresas()
            .subscribe(function (resp) {
            _this.girosEmpresa = resp;
            console.log(_this.girosEmpresa);
        });
        this._perfilCandidatoService.GetMonths()
            .subscribe(function (resp) {
            _this.meses = resp;
        });
        this._perfilCandidatoService.GetYears()
            .subscribe(function (resp) {
            _this.years = resp;
        });
    }
    ExperienciaProfesionalComponent.prototype.filterAreas = function (event) {
        var _this = this;
        var query = event.query;
        this._perfilCandidatoService.GetAreas(query)
            .then(function (areas) {
            _this.filteredAreas = areas;
        });
    };
    ExperienciaProfesionalComponent.prototype.SetAreaId = function (event) {
        this.Experiencias.get('areaId').setValue(event.id);
        this.Experiencias.get('area').setValue(null);
    };
    return ExperienciaProfesionalComponent;
}());
__decorate([
    core_1.Input('group'),
    __metadata("design:type", forms_1.FormGroup)
], ExperienciaProfesionalComponent.prototype, "Experiencias", void 0);
ExperienciaProfesionalComponent = __decorate([
    core_1.Component({
        selector: 'experiencias',
        templateUrl: 'app/Components/PerfilCandidatoComponents/ExperienciaProfesionalComponent/ExperienciaProfesional.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder,
        PerfilCandidato_Service_1.PerfilCandidatoService])
], ExperienciaProfesionalComponent);
exports.ExperienciaProfesionalComponent = ExperienciaProfesionalComponent;
//# sourceMappingURL=ExperienciaProfesional.componet.js.map