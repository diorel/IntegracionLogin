export class Pais
{
    id: number;
    nombre: string;
}
export class Estado
{
    Id: number;
    Nombre:string ;
}

export class Municipio
{
    id: number;
    nombre: string;
}

export class Colonia
{
    id: number;
    colonia: string;
    CP: string;
    tipoColonia: string;
    municipioId: number;
    estadoId: number;
    paisId: number;
}
export class DatosPersonales
{
    telCasa: string;
    telCelular: string;
    telOficina: string;
    esDiscapacitado: boolean;
    puedeRehubicarse: boolean;
    puedeViajar: boolean;
    CorreoElectronico: boolean;
    Celular: boolean;
    whatsApp: boolean;
    telLocal: boolean;
    estadoCivilId: number;
    generoId: number;
    tipoDiscapacidadId: number;
    tieneLicenciaConducir: boolean;
    tipoLicenciaId: number;

    fechaNacimiento: Date;
    paisNacimiento: Pais;
    estadoNacimiento: Estado;
    municipioNacimiento: Municipio;
}

export class Direccion
{
     id: number;           
     calle: string;
     numeroInterior:string ;
     numeroExterior: string;
     paisId: number
     pais: Pais;
     estadoId: number;
     estado: Estado;
     municipioId: number;
     municipio: Municipio;
     coloniaId :number;
     colonia: Colonia;
     cp : string;
}
export class Identificaciones
{
    tieneLicenciaConducir: boolean;
    tipoLicencia: number;
    tieneVehiculoPropio: boolean;
    curp: string;
    rfc: string;
    nss: string;
}

export class Candidato
{
    id: number;
    nombre: string;
    apellidoPaterno: string;
    apellidoMaterno: string;
    email: string;
    imgProfileUrl: string;
    datospersonales: DatosPersonales;
    direccion: Direccion;
    identificaciones: Identificaciones;
}