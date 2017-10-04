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
var CandidatosService = (function () {
    function CandidatosService(_http) {
        this._http = _http;
        this._urlCandidatos = "api/candidatos";
    }
    CandidatosService.prototype.GetCandidatos = function () {
        return this._http.get(this._urlCandidatos)
            .map(function (result) { return result.json(); })
            .catch(this.handleErrorObservable);
    };
    CandidatosService.prototype.AddCandidato = function (candidato) {
        var headers = new http_1.Headers({ 'Content-Type': 'application/json' });
        var options = new http_1.RequestOptions({ headers: headers });
        return this._http.post(this._urlCandidatos, JSON.stringify(candidato), options)
            .map(function (result) { return result.json(); })
            .catch(this.handleErrorObservable);
    };
    CandidatosService.prototype.GetCandidato = function (id) {
        return this._http.get(this.getUrlCandidatos(id))
            .map(function (result) {
            //console.log(result.json());
            return result.json();
        })
            .catch(this.handleErrorObservable);
    };
    CandidatosService.prototype.EditCandidato = function (candidato, candidatoId) {
        var headers = new http_1.Headers({ 'Content-Type': 'application/json' });
        var options = new http_1.RequestOptions({ headers: headers });
        return this._http.put(this.getUrlCandidatos(candidatoId), JSON.stringify(candidato), options);
        //.map(result => {
        //    console.log("EditCandidato");
        //    console.log(result);
        //    result.json();
        //});
    };
    CandidatosService.prototype.DeleteCandidato = function (id) {
        var headers = new http_1.Headers({ 'Content-Type': 'application/json' });
        var options = new http_1.RequestOptions({ headers: headers });
        return this._http.delete(this.getUrlCandidatos(id));
        //    .map(res => res.json())
        //.catch(this.handleErrorObservable);
    };
    CandidatosService.prototype.handleErrorObservable = function (error) {
        return Observable_1.Observable.throw(error);
    };
    CandidatosService.prototype.getUrlCandidatos = function (id) {
        return this._urlCandidatos + "/" + id;
    };
    return CandidatosService;
}());
CandidatosService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], CandidatosService);
exports.CandidatosService = CandidatosService;
//# sourceMappingURL=Candidatos.Service.js.map