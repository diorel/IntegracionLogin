import { Component, Input } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { CalendarModule, AutoCompleteModule, CheckboxModule } from 'primeng/primeng';

import { PerfilCandidatoService } from '../../../Services/PerfilCandidato.Service';

@Component({
    selector: 'formaciones',
    templateUrl:'app/Components/PerfilCandidatoComponents/FormacionComponent/Formacion.component.html'
})
export class FormacionComponent {
    @Input('group')
    public Formaciones: FormGroup;
    filteredInstituciones: any[];
    filteredCarreras: any[];
    Estatus: any[];
    meses: any[];
    years: any[];
    gradosEstudio: any[];
    documentosValidadores: any[];
    constructor(
        private fb: FormBuilder,
        private _perfilCandidatoService: PerfilCandidatoService)
    {
     

        this._perfilCandidatoService.GetEstatus()
            .subscribe(resp => {
                this.Estatus = resp;
            });
        this._perfilCandidatoService.GetGradoEstudio()
            .subscribe(resp => {
                this.gradosEstudio = resp;
            });
        this._perfilCandidatoService.GetMonths()
            .subscribe(resp => {
                this.meses = resp;
            });
        this._perfilCandidatoService.GetYears()
            .subscribe(resp => {
                this.years = resp;
            });
        this._perfilCandidatoService.GetDocumentosValidadores()
            .subscribe(resp => {
                this.documentosValidadores = resp;
            });
    }

    filterInstituciones(event: any)
    {
        let query = event.query;
        this._perfilCandidatoService.GetInstituciones(query)
            .then(instituciones => {
                this.filteredInstituciones = instituciones;
                console.log(this.filteredInstituciones);
            });
    }
    filterCarreras(event: any) {
        let query = event.query;
        this._perfilCandidatoService.GetCarreras(query)
            .then(carreras => {
                this.filteredCarreras = carreras;
                console.log(this.filteredInstituciones);
            });
    }
    SetCarreraId(event:any)
    {
        this.Formaciones.get('carreraId').setValue(event.id);
        this.Formaciones.get('carrera').setValue(null);
    }

    SetInstitucionId(event: any)
    {
        this.Formaciones.get('institucionEducativaId').setValue(event.id)
        this.Formaciones.get('institucionEducativa').setValue(null)
    }
      
}