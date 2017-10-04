"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var alta_candidato_component_1 = require("./Components/alta.candidato.component");
var perfil_candidato_component_1 = require("./Components/PerfilCandidatoComponents/perfil-candidato.component");
var not_found_component_1 = require("./Components/not-found.component");
var CandidatosTable_component_1 = require("./Components/TablaCandidatos/CandidatosTable.component");
var appRoutes = [
    { path: '', component: CandidatosTable_component_1.CandidatosTableComponent, pathMatch: 'full' },
    { path: 'altaCandidato', component: alta_candidato_component_1.AltaCandidato },
    { path: 'altaCandidato/:id', component: alta_candidato_component_1.AltaCandidato },
    { path: 'PerfilCandidato', component: perfil_candidato_component_1.CandidatoPerfil },
    { path: 'PerfilCandidato/:idCandidato', component: perfil_candidato_component_1.CandidatoPerfil },
    { path: 'not-found', component: not_found_component_1.NotFoundComponent },
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map