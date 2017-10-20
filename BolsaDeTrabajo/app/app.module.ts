import { APP_BASE_HREF } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { CalendarModule, AutoCompleteModule, CheckboxModule } from 'primeng/primeng';
import { FormsModule } from '@angular/forms'
import { HttpModule } from '@angular/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


import { AppComponent } from './app.component';
import { routing } from './app.routing';
import { AltaCandidato } from './Components/alta.candidato.component';
import { CandidatoPerfil } from './Components/PerfilCandidatoComponents/perfil-candidato.component';
import { IdiomaComponent } from './Components/PerfilCandidatoComponents/IdiomaComponent/idioma.component';
import { FormacionComponent } from './Components/PerfilCandidatoComponents/FormacionComponent/Formacion.Component';
import { ExperienciaProfesionalComponent} from './Components/PerfilCandidatoComponents/ExperienciaProfesionalComponent/ExperienciaProfesional.componet';
import { CursoComponent } from './Components/PerfilCandidatoComponents/CursoComponent/curso.component';
import { ConocimientoComponent } from './Components/PerfilCandidatoComponents/ConocimientosHabilidadesComponent/Conocimiento.component';
import { AboutMeComponent } from './Components/PerfilCandidatoComponents/AboutMe/aboutme.component';
import { NotFoundComponent } from './Components/not-found.component';
import { CandidatosTableComponent } from './Components/TablaCandidatos/CandidatosTable.component';
import { CatalogosService } from './Services/catalogos.service';
import { PerfilCandidatoService } from './Services/PerfilCandidato.Service';
import { PerfilImageService } from './Services/ProfileImage.service';
import { CandidatosService } from './Services/Candidatos.Service';
import { ValidacionIdentificaciones } from './Services/ValidacionIdentificaciones.service';
import { OnlyNumber } from './Directives/OnlyNumbers.Directive';
import { OnlyLetters } from './Directives/OnlyLetters.directive';
import { CURPValidator } from './Components/Validators/CURP.validator';

import { ImageUploaderComponent } from './Components/ImageProfile/imageProfile-Upload.component';

@NgModule({
    imports: [BrowserModule, ReactiveFormsModule, FormsModule, HttpModule, routing, CalendarModule, AutoCompleteModule, BrowserAnimationsModule, CheckboxModule],
    declarations: [AppComponent, AltaCandidato, CandidatosTableComponent, CandidatoPerfil, IdiomaComponent, FormacionComponent, CursoComponent, ConocimientoComponent, ExperienciaProfesionalComponent, ImageUploaderComponent, AboutMeComponent, OnlyNumber, OnlyLetters, NotFoundComponent ],
    providers: [{ provide: APP_BASE_HREF, useValue: '/' }, CatalogosService, CandidatosService, PerfilCandidatoService, CURPValidator, ValidacionIdentificaciones, PerfilImageService],
    bootstrap: [AppComponent]

})
export class AppModule { }

//providers: [{ provide: APP_BASE_HREF, useValue: '/' }],

