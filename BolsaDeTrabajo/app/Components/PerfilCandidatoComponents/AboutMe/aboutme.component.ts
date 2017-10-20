import { Component,Input } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

import { PerfilCandidatoService } from '../../../Services/PerfilCandidato.Service';

@Component({
    selector: 'aboutme',
    templateUrl:'app/Components/PerfilCandidatoComponents/AboutMe/aboutme.component.html'
})
export class AboutMeComponent
{
    @Input('group')
    public aboutMe: FormGroup;

    filteredAreaExperiencia: any[];
    gradosExperiencia: any[];
    areasInteres: any[];
    constructor(private _fb: FormBuilder, private _PerfilCandidatoService: PerfilCandidatoService) {
        this._PerfilCandidatoService.GetGradosExperiencia()
            .subscribe(gradosExperiencia => {
                this.gradosExperiencia = gradosExperiencia;
            });
        this._PerfilCandidatoService.GetAreasInteres()
            .subscribe(areas => {
                this.areasInteres = areas;
            });
        
    }
    filterAreaExperiencia(event: any) {
        let query = event.query;
        this._PerfilCandidatoService.GetAreasExperiencia(query)
            .then(areasExperiencia => {
                this.filteredAreaExperiencia = areasExperiencia;
            })
    }

    SetAreaExperienciaId(event:any)
    {
        this.aboutMe.get('areaExperienciaId').setValue(event.id);
        this.aboutMe.get('areaExperiencia').setValue(null);
    }
}