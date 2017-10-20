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
var AboutMeComponent = (function () {
    function AboutMeComponent(_fb, _PerfilCandidatoService) {
        var _this = this;
        this._fb = _fb;
        this._PerfilCandidatoService = _PerfilCandidatoService;
        this._PerfilCandidatoService.GetGradosExperiencia()
            .subscribe(function (gradosExperiencia) {
            _this.gradosExperiencia = gradosExperiencia;
        });
        this._PerfilCandidatoService.GetAreasInteres()
            .subscribe(function (areas) {
            _this.areasInteres = areas;
        });
    }
    AboutMeComponent.prototype.filterAreaExperiencia = function (event) {
        var _this = this;
        var query = event.query;
        this._PerfilCandidatoService.GetAreasExperiencia(query)
            .then(function (areasExperiencia) {
            _this.filteredAreaExperiencia = areasExperiencia;
        });
    };
    AboutMeComponent.prototype.SetAreaExperienciaId = function (event) {
        this.aboutMe.get('areaExperienciaId').setValue(event.id);
        this.aboutMe.get('areaExperiencia').setValue(null);
    };
    return AboutMeComponent;
}());
__decorate([
    core_1.Input('group'),
    __metadata("design:type", forms_1.FormGroup)
], AboutMeComponent.prototype, "aboutMe", void 0);
AboutMeComponent = __decorate([
    core_1.Component({
        selector: 'aboutme',
        templateUrl: 'app/Components/PerfilCandidatoComponents/AboutMe/aboutme.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder, PerfilCandidato_Service_1.PerfilCandidatoService])
], AboutMeComponent);
exports.AboutMeComponent = AboutMeComponent;
//# sourceMappingURL=aboutme.component.js.map