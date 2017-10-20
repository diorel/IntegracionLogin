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
var ConocimientoComponent = (function () {
    function ConocimientoComponent(fb, _perfilCandidatoService) {
        var _this = this;
        this.fb = fb;
        this._perfilCandidatoService = _perfilCandidatoService;
        this._perfilCandidatoService.GetNiveles()
            .subscribe(function (niveles) {
            _this.niveles = niveles;
        });
    }
    ConocimientoComponent.prototype.filterInstituciones = function (event) {
        var _this = this;
        var query = event.query;
        this._perfilCandidatoService.GetInstituciones(query)
            .then(function (instituciones) {
            _this.filteredInstituciones = instituciones;
        });
    };
    ConocimientoComponent.prototype.SetInstitucionId = function (event) {
        this.Conocimientos.get('institucionEducativaId').setValue(event.id);
        this.Conocimientos.get('institucionEducativa').setValue(null);
    };
    return ConocimientoComponent;
}());
__decorate([
    core_1.Input('group'),
    __metadata("design:type", forms_1.FormGroup)
], ConocimientoComponent.prototype, "Conocimientos", void 0);
ConocimientoComponent = __decorate([
    core_1.Component({
        selector: 'conocimientos',
        templateUrl: 'app/Components/PerfilCandidatoComponents/ConocimientosHabilidadesComponent/Conocimiento.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder,
        PerfilCandidato_Service_1.PerfilCandidatoService])
], ConocimientoComponent);
exports.ConocimientoComponent = ConocimientoComponent;
//# sourceMappingURL=Conocimiento.component.js.map