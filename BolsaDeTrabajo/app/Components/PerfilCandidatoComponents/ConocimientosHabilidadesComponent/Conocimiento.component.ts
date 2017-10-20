import { Component, Input } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { CalendarModule, AutoCompleteModule, CheckboxModule } from 'primeng/primeng';

import { PerfilCandidatoService } from '../../../Services/PerfilCandidato.Service';

@Component({
    selector: 'conocimientos',
    templateUrl: 'app/Components/PerfilCandidatoComponents/ConocimientosHabilidadesComponent/Conocimiento.component.html'
})
export class ConocimientoComponent {
    @Input('group')
    public Conocimientos: FormGroup;

    filteredInstituciones: any[];
    niveles: any[]
    constructor(
        private fb: FormBuilder,
        private _perfilCandidatoService: PerfilCandidatoService) {

        this._perfilCandidatoService.GetNiveles()
            .subscribe(niveles => {
                this.niveles = niveles;
            })
    }

    filterInstituciones(event: any) {
        let query = event.query;
        this._perfilCandidatoService.GetInstituciones(query)
            .then(instituciones => {
                this.filteredInstituciones = instituciones;
            });
    }


    SetInstitucionId(event: any) {
        this.Conocimientos.get('institucionEducativaId').setValue(event.id)
        this.Conocimientos.get('institucionEducativa').setValue(null)
    }

}