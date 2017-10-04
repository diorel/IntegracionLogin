import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { IPalabraInconveniente } from '../Models/IPalabraInconveniente';
import { IValidState } from '../Models/IValidState';
import { MunettFormat } from '../Models/munettFormat'; 

@Injectable()
export class ValidacionIdentificaciones {
    private _urlPalabraInapropiada = "api/palabrasInconvenientes";
    //api/palabrasInconvenientes/?palabra = MARIA & opt=1

    constructor(private _http: Http) { }

    IsPalabraInconveniente(palabra: string): Observable<IPalabraInconveniente> {
        return this._http.get(this._urlPalabraInapropiada + '/?palabra=' + palabra)
            .map(result => result.json())
            .catch(this.handleErrorObservable);
    }
    ValidarNombre(palabra: string): Observable<IValidState> {
        return this._http.get(this._urlPalabraInapropiada + '/?palabra=' + palabra +'&opt='+1)
            .map(result => {
                console.log('ValidarNombre');
                console.log(result.json());
                return result.json()              
            })
            .catch(this.handleErrorObservable);
    }
    ValidarApellido(palabra: string){
        return this._http.get(this._urlPalabraInapropiada + '/?palabra=' + palabra + '&opt=' + 2)
            .map(result => {
                console.log('validar Apellido');
                console.log(result.json() );
                return result.json()
            })
            .catch(this.handleErrorObservable);
    }
    TestMunett(munett: MunettFormat) {
        let headers = new Headers({
            'Content-Type': 'application/json',
            'Authorization': 'Token token=1bd627ff6b61d1c526325dfc7f70feda'
        });
        let options = new RequestOptions({ headers: headers });
        return this._http.post("https://curp.munett.com/v1/curp", JSON.stringify(munett), options)
            .map(result => {
                console.log('validar Munett');
                console.log(result.json());
                return result.json()
            })
            .catch(this.handleErrorObservable);
    }
    private handleErrorObservable(error: Response | any) {
        return Observable.throw(error);
    }
}