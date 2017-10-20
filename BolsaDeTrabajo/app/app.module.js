"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var common_1 = require("@angular/common");
var platform_browser_1 = require("@angular/platform-browser");
var primeng_1 = require("primeng/primeng");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var core_1 = require("@angular/core");
var forms_2 = require("@angular/forms");
var animations_1 = require("@angular/platform-browser/animations");
var app_component_1 = require("./app.component");
var app_routing_1 = require("./app.routing");
var alta_candidato_component_1 = require("./Components/alta.candidato.component");
var perfil_candidato_component_1 = require("./Components/PerfilCandidatoComponents/perfil-candidato.component");
var idioma_component_1 = require("./Components/PerfilCandidatoComponents/IdiomaComponent/idioma.component");
var Formacion_Component_1 = require("./Components/PerfilCandidatoComponents/FormacionComponent/Formacion.Component");
var ExperienciaProfesional_componet_1 = require("./Components/PerfilCandidatoComponents/ExperienciaProfesionalComponent/ExperienciaProfesional.componet");
var curso_component_1 = require("./Components/PerfilCandidatoComponents/CursoComponent/curso.component");
var Conocimiento_component_1 = require("./Components/PerfilCandidatoComponents/ConocimientosHabilidadesComponent/Conocimiento.component");
var aboutme_component_1 = require("./Components/PerfilCandidatoComponents/AboutMe/aboutme.component");
var not_found_component_1 = require("./Components/not-found.component");
var CandidatosTable_component_1 = require("./Components/TablaCandidatos/CandidatosTable.component");
var catalogos_service_1 = require("./Services/catalogos.service");
var PerfilCandidato_Service_1 = require("./Services/PerfilCandidato.Service");
var ProfileImage_service_1 = require("./Services/ProfileImage.service");
var Candidatos_Service_1 = require("./Services/Candidatos.Service");
var ValidacionIdentificaciones_service_1 = require("./Services/ValidacionIdentificaciones.service");
var OnlyNumbers_Directive_1 = require("./Directives/OnlyNumbers.Directive");
var OnlyLetters_directive_1 = require("./Directives/OnlyLetters.directive");
var CURP_validator_1 = require("./Components/Validators/CURP.validator");
var imageProfile_Upload_component_1 = require("./Components/ImageProfile/imageProfile-Upload.component");
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule, forms_2.ReactiveFormsModule, forms_1.FormsModule, http_1.HttpModule, app_routing_1.routing, primeng_1.CalendarModule, primeng_1.AutoCompleteModule, animations_1.BrowserAnimationsModule, primeng_1.CheckboxModule],
        declarations: [app_component_1.AppComponent, alta_candidato_component_1.AltaCandidato, CandidatosTable_component_1.CandidatosTableComponent, perfil_candidato_component_1.CandidatoPerfil, idioma_component_1.IdiomaComponent, Formacion_Component_1.FormacionComponent, curso_component_1.CursoComponent, Conocimiento_component_1.ConocimientoComponent, ExperienciaProfesional_componet_1.ExperienciaProfesionalComponent, imageProfile_Upload_component_1.ImageUploaderComponent, aboutme_component_1.AboutMeComponent, OnlyNumbers_Directive_1.OnlyNumber, OnlyLetters_directive_1.OnlyLetters, not_found_component_1.NotFoundComponent],
        providers: [{ provide: common_1.APP_BASE_HREF, useValue: '/' }, catalogos_service_1.CatalogosService, Candidatos_Service_1.CandidatosService, PerfilCandidato_Service_1.PerfilCandidatoService, CURP_validator_1.CURPValidator, ValidacionIdentificaciones_service_1.ValidacionIdentificaciones, ProfileImage_service_1.PerfilImageService],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//providers: [{ provide: APP_BASE_HREF, useValue: '/' }],
//# sourceMappingURL=app.module.js.map