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
var PerfilCandidatoService = (function () {
    function PerfilCandidatoService(_http) {
        this._http = _http;
        this.UrlIdiomas = 'api/idiomas';
        this.UrlNiveles = 'api/niveles';
        this.UrlEstatus = 'api/estadosEstudio';
        this.UrlInstituciones = 'api/institucionEducativa';
        this.UrlCarreras = 'api/carreras';
        this.UrlMonths = 'api/months';
        this.UrlYears = 'api/years';
        this.UrlGradosestudio = 'api/gradosEstudio';
        this.UrlDocumentosValidadores = 'api/documentosValidadores';
        this.UrlPerfilCandidato = 'api/PerfilCandidato';
        this.UrlUploadImage = 'api/ProfileImageUploader';
    }
    PerfilCandidatoService.prototype.GetIdiomas = function (query) {
        return this._http.get(this.UrlIdiomas + "/?query=" + query)
            .map(function (resp) { return resp.json(); })
            .toPromise()
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetNiveles = function () {
        return this._http.get(this.UrlNiveles)
            .map(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetInstituciones = function (query) {
        return this._http.get(this.UrlInstituciones + "/?query=" + query)
            .map(function (resp) { return resp.json(); })
            .toPromise()
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetCarreras = function (query) {
        return this._http.get(this.UrlCarreras + "/?query=" + query)
            .map(function (resp) { return resp.json(); })
            .toPromise()
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetEstatus = function () {
        return this._http.get(this.UrlEstatus)
            .map(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetMonths = function () {
        return this._http.get(this.UrlMonths)
            .map(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetYears = function () {
        return this._http.get(this.UrlYears)
            .map(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetGradoEstudio = function () {
        return this._http.get(this.UrlGradosestudio)
            .map(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetDocumentosValidadores = function () {
        return this._http.get(this.UrlDocumentosValidadores)
            .map(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.GetPerfilCandidato = function (id) {
        return this._http.get(this.UrlPerfilCandidato + "/?id=" + id)
            .map(function (resp) { return resp.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.AddPerfilCandidato = function (id, perfilCandidato) {
        var headers = new http_1.Headers({ 'Content-Type': 'application/json' });
        var options = new http_1.RequestOptions({ headers: headers });
        return this._http.post(this.UrlPerfilCandidato + '/?id=' + id, JSON.stringify(perfilCandidato), options)
            .map(function (result) { return result.json(); })
            .catch(this.handleError);
    };
    PerfilCandidatoService.prototype.handleError = function (error) {
        return Observable_1.Observable.throw(error.json().error || 'Server error');
    };
    return PerfilCandidatoService;
}());
PerfilCandidatoService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], PerfilCandidatoService);
exports.PerfilCandidatoService = PerfilCandidatoService;
//# sourceMappingURL=PerfilCandidato.Service.js.map