import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { ICandidato } from '../Models/ICandidato';
import {  Candidato } from '../Models/Candidato';

@Injectable()
export class CandidatosService{
    private _urlCandidatos = "api/candidatos";

    constructor(private _http: Http)
    { }

    GetCandidatos(): Observable<ICandidato[]>
    {
        return this._http.get(this._urlCandidatos)
            .map(result => result.json())
            .catch(this.handleErrorObservable);
    }

    AddCandidato(candidato: any): Observable<any>
    {
       
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this._http.post(this._urlCandidatos, JSON.stringify(candidato), options)
            .map(result =>result.json())
            .catch(this.handleErrorObservable); 
    }

    GetCandidato(id: number): Observable<Candidato>
    {
        return this._http.get(this.getUrlCandidatos(id))
            .map(result => {    
                //console.log(result.json());
                return result.json();
            })
            .catch(this.handleErrorObservable);
    }

    EditCandidato(candidato: Candidato, candidatoId: number) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this._http.put(this.getUrlCandidatos(candidatoId), JSON.stringify(candidato), options);
            //.map(result => {
            //    console.log("EditCandidato");
            //    console.log(result);
            //    result.json();
            //});
    }
 
    DeleteCandidato(id: number) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this._http.delete(this.getUrlCandidatos(id));
        //    .map(res => res.json())
        //.catch(this.handleErrorObservable);
    }
    private handleErrorObservable(error: Response | any) { 
        return Observable.throw( error);
    }
    

    getUrlCandidatos(id: number) {
        return this._urlCandidatos + "/"+ id;
    }
}