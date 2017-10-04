import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { PerfilCandidato } from '../Models/PerfilCandidato';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
@Injectable()
export class PerfilCandidatoService {

    private UrlIdiomas: string = 'api/idiomas'
    private UrlNiveles: string = 'api/niveles'
    private UrlEstatus: string = 'api/estadosEstudio'
    private UrlInstituciones: string = 'api/institucionEducativa'
    private UrlCarreras: string = 'api/carreras'
    private UrlMonths: string = 'api/months'
    private UrlYears: string = 'api/years'
    private UrlGradosestudio: string = 'api/gradosEstudio'
    private UrlDocumentosValidadores: string = 'api/documentosValidadores'
    private UrlPerfilCandidato: string = 'api/PerfilCandidato'
    private UrlUploadImage: string = 'api/ProfileImageUploader'
    constructor(private _http: Http){}
    GetIdiomas(query: string) {
        return this._http.get(this.UrlIdiomas + "/?query=" + query)
            .map(resp => resp.json())
            .toPromise()
            .catch(this.handleError);
    }

    GetNiveles()
    {
        return this._http.get(this.UrlNiveles)
            .map(resp => resp.json())
            .catch(this.handleError);
    }
    GetInstituciones(query: string) {
        return this._http.get(this.UrlInstituciones + "/?query=" + query)
            .map(resp => resp.json())
            .toPromise()
            .catch(this.handleError);
    }
    GetCarreras(query: string) {
        return this._http.get(this.UrlCarreras + "/?query=" + query)
            .map(resp => resp.json())
            .toPromise()
            .catch(this.handleError);
    }

    GetEstatus() {
        return this._http.get(this.UrlEstatus)
            .map(resp => resp.json())
            .catch(this.handleError);
    }
    GetMonths() {
        return this._http.get(this.UrlMonths)
            .map(resp => resp.json())
            .catch(this.handleError);
    }
    GetYears() {
        return this._http.get(this.UrlYears)
            .map(resp => resp.json())
            .catch(this.handleError);
    }
    GetGradoEstudio() {
        return this._http.get(this.UrlGradosestudio)
            .map(resp => resp.json())
            .catch(this.handleError);
    }
    GetDocumentosValidadores() {
        return this._http.get(this.UrlDocumentosValidadores)
            .map(resp => resp.json())
            .catch(this.handleError);
    }

    GetPerfilCandidato(id: number): Observable<PerfilCandidato>
    {
        return this._http.get(this.UrlPerfilCandidato + "/?id=" + id)
            .map(resp => resp.json())
            .catch(this.handleError);
    }
    AddPerfilCandidato(id:number, perfilCandidato: PerfilCandidato): Observable<any> {

        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this._http.post(this.UrlPerfilCandidato+'/?id='+id, JSON.stringify(perfilCandidato), options)
            .map(result => result.json())
            .catch(this.handleError);
    }

   
    private handleError(error: Response) {
        return Observable.throw(error.json().error || 'Server error');
    }
}

