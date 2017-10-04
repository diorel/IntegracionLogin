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
var IdiomaComponent = (function () {
    function IdiomaComponent(fb, _perfilCandidatoService) {
        var _this = this;
        this.fb = fb;
        this._perfilCandidatoService = _perfilCandidatoService;
        this._perfilCandidatoService.GetNiveles()
            .subscribe(function (niveles) {
            _this.niveles = niveles;
        });
    }
    IdiomaComponent.prototype.filterIdiomas = function (event) {
        var _this = this;
        var query = event.query;
        this._perfilCandidatoService.GetIdiomas(query)
            .then(function (idiomas) {
            _this.filteredIdiomas = idiomas;
            console.log(_this.filteredIdiomas);
        });
    };
    IdiomaComponent.prototype.SetIdiomaId = function (event) {
        this.language.get('idiomaId').setValue(event.id);
        this.language.get('idioma').setValue(null);
        //this.idIdioma = event.id;
        console.log(this.language.get('idiomaId').value);
    };
    return IdiomaComponent;
}());
__decorate([
    core_1.Input('group'),
    __metadata("design:type", forms_1.FormGroup)
], IdiomaComponent.prototype, "language", void 0);
IdiomaComponent = __decorate([
    core_1.Component({
        selector: 'idiomas',
        templateUrl: 'app/Components/PerfilCandidatoComponents/IdiomaComponent/Idioma.component.html'
    }),
    __metadata("design:paramtypes", [forms_1.FormBuilder,
        PerfilCandidato_Service_1.PerfilCandidatoService])
], IdiomaComponent);
exports.IdiomaComponent = IdiomaComponent;
//# sourceMappingURL=idioma.component.js.map