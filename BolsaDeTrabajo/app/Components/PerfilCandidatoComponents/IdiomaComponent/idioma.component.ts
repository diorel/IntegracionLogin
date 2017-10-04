import { Component, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { CalendarModule, AutoCompleteModule, CheckboxModule } from 'primeng/primeng'; 

import { PerfilCandidatoService } from '../../../Services/PerfilCandidato.Service';

@Component({
    selector: 'idiomas',
    templateUrl:'app/Components/PerfilCandidatoComponents/IdiomaComponent/Idioma.component.html'
})
export class IdiomaComponent {
    @Input('group')
    public language: FormGroup;

    //@Output('GetIdiomaId')
    //setIdiomaId = new EventEmitter<number>();
    //idIdioma: number = 0;
    filteredIdiomas: any[];
    niveles: any[]

    constructor(private fb: FormBuilder,
        private _perfilCandidatoService: PerfilCandidatoService)
    {

        this._perfilCandidatoService.GetNiveles()
            .subscribe(niveles => {
                this.niveles = niveles;
            })
    }
    filterIdiomas(event: any)
    {
        let query = event.query; 
        this._perfilCandidatoService.GetIdiomas(query)
            .then(idiomas => {                
                this.filteredIdiomas = idiomas;
                console.log(this.filteredIdiomas);
            });
        
    }

    SetIdiomaId(event: any) {
        this.language.get('idiomaId').setValue(event.id);
        this.language.get('idioma').setValue(null);
        //this.idIdioma = event.id;
        console.log(this.language.get('idiomaId').value);
    }
}