import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule, RouterLink } from '@angular/router';

import { AltaCandidato } from './Components/alta.candidato.component'
import { CandidatoPerfil } from './Components/PerfilCandidatoComponents/perfil-candidato.component';
import { NotFoundComponent } from './Components/not-found.component';
import { CandidatosTableComponent } from './Components/TablaCandidatos/CandidatosTable.component';



const appRoutes: Routes = [
    { path: '', component: CandidatosTableComponent,  pathMatch: 'full' },
    { path: 'altaCandidato', component: AltaCandidato },
    { path: 'altaCandidato/:id', component: AltaCandidato },
    { path: 'PerfilCandidato', component: CandidatoPerfil },
    { path: 'PerfilCandidato/:idCandidato', component: CandidatoPerfil },
    { path: 'not-found', component: NotFoundComponent },

];

export const routing: ModuleWithProviders =
    RouterModule.forRoot(appRoutes);
