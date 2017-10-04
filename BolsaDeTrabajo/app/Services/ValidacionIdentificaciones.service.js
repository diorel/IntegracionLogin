"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
var Observable_1 = require("rxjs/Observable");
require("rxjs/add/operator/map");
require("rxjs/add/operator/catch");
var ValidacionIdentificaciones = (function () {
    //api/palabrasInconvenientes/?palabra = MARIA & opt=1
    function ValidacionIdentificaciones(_http) {
        this._http = _http;
        this._urlPalabraInapropiada = "api/palabrasInconvenientes";
    }
    ValidacionIdentificaciones.prototype.IsPalabraInconveniente = function (palabra) {
        return this._http.get(this._urlPalabraInapropiada + '/?palabra=' + palabra)
            .map(function (result) { return result.json(); })
            .catch(this.handleErrorObservable);
    };
    ValidacionIdentificaciones.prototype.ValidarNombre = function (palabra) {
        return this._http.get(this._urlPalabraInapropiada + '/?palabra=' + palabra + '&opt=' + 1)
            .map(function (result) {
            console.log('ValidarNombre');
            console.log(result.json());
            return result.json();
        })
            .catch(this.handleErrorObservable);
    };
    ValidacionIdentificaciones.prototype.ValidarApellido = function (palabra) {
        return this._http.get(this._urlPalabraInapropiada + '/?palabra=' + palabra + '&opt=' + 2)
            .map(function (result) {
            console.log('validar Apellido');
            console.log(result.json());
            return result.json();
        })
            .catch(this.handleErrorObservable);
    };
    ValidacionIdentificaciones.prototype.TestMunett = function (munett) {
        var headers = new http_1.Headers({
            'Content-Type': 'application/json',
            'Authorization': 'Token token=1bd627ff6b61d1c526325dfc7f70feda'
        });
        var options = new http_1.RequestOptions({ headers: headers });
        return this._http.post("https://curp.munett.com/v1/curp", JSON.stringify(munett), options)
            .map(function (result) {
            console.log('validar Munett');
            console.log(result.json());
            return result.json();
        })
            .catch(this.handleErrorObservable);
    };
    ValidacionIdentificaciones.prototype.handleErrorObservable = function (error) {
        return Observable_1.Observable.throw(error);
    };
    return ValidacionIdentificaciones;
}());
ValidacionIdentificaciones = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], ValidacionIdentificaciones);
exports.ValidacionIdentificaciones = ValidacionIdentificaciones;
//# sourceMappingURL=ValidacionIdentificaciones.service.js.map