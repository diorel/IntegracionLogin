import { Component, Input } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { CalendarModule, AutoCompleteModule, CheckboxModule } from 'primeng/primeng';

import { PerfilCandidatoService } from '../../../Services/PerfilCandidato.Service';

@Component({
    selector: 'cursos',
    templateUrl: 'app/Components/PerfilCandidatoComponents/CursoComponent/curso.component.html'
})
export class CursoComponent {
    @Input('group')
    public Cursos: FormGroup;

    filteredInstituciones: any[];   
    meses: any[];
    years: any[];
    constructor(
        private fb: FormBuilder,
        private _perfilCandidatoService: PerfilCandidatoService) {
        
        this._perfilCandidatoService.GetMonths()
            .subscribe(resp => {
                this.meses = resp;
            });
        this._perfilCandidatoService.GetYears()
            .subscribe(resp => {
                this.years = resp;
            });
    }

    filterInstituciones(event: any) {
        let query = event.query;
        this._perfilCandidatoService.GetInstituciones(query)
            .then(instituciones => {
                this.filteredInstituciones = instituciones;
            });
    }
  

    SetInstitucionId(event: any) {
        this.Cursos.get('institucionEducativaId').setValue(event.id)
        this.Cursos.get('institucionEducativa').setValue(null)
    }

}