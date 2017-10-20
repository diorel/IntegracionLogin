import { Component, Input } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { CalendarModule, AutoCompleteModule, CheckboxModule } from 'primeng/primeng';

import { PerfilCandidatoService } from '../../../Services/PerfilCandidato.Service';

@Component({
    selector: 'experiencias',
    templateUrl: 'app/Components/PerfilCandidatoComponents/ExperienciaProfesionalComponent/ExperienciaProfesional.component.html'
})
export class ExperienciaProfesionalComponent {
    @Input('group')
    public Experiencias: FormGroup;

    filteredAreas: any[];
    meses: any[];
    years: any[];
    girosEmpresa: any[];
    constructor(
        private fb: FormBuilder,
        private _perfilCandidatoService: PerfilCandidatoService) {

        this._perfilCandidatoService.GetGirosEmpresas()
            .subscribe(resp => {
                this.girosEmpresa = resp;
                console.log(this.girosEmpresa);
            });
        this._perfilCandidatoService.GetMonths()
            .subscribe(resp => {
                this.meses = resp;
            });
        this._perfilCandidatoService.GetYears()
            .subscribe(resp => {
                this.years = resp;
            });
    }

    filterAreas(event: any) {
        let query = event.query;
        this._perfilCandidatoService.GetAreas(query)
            .then(areas => {
                this.filteredAreas = areas;
            });
    }
    SetAreaId(event: any) {
        this.Experiencias.get('areaId').setValue(event.id)
        this.Experiencias.get('area').setValue(null)
    }

}