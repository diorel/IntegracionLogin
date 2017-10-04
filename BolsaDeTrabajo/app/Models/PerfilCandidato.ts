export class PerfilCandidato
{
    id: number;
    candidatoId: number;
    formaciones: Formacion[];
    idiomas: PerfilIdioma[];
}
export class GradoEstudio
{
    Id: number;
    gradoEstudio: string;
}

export class EstadoEstudio
{
    Id: number;
    estadoEstudio: string;
}
export class DocumentoValidador
{
    id: number;
    documentoValidador: string;
}
export class Carrera {
    Id: number;
    carrera: string;
}

export class InstitucionEducativa
{
    Id: number;
    institucionEducativa: string
}
export class Formacion
{
    id: number;
    perfilCandidatoId: number;
    institucionEducativaId: number;
    institucionEducativa: InstitucionEducativa;
    gradoEstudioId: number;
    gradoEstudio: GradoEstudio;
    estadoEstudioId: number;
    estadoEstudio: EstadoEstudio;
    documentoValidadorId: number;
    documentoValidador: DocumentoValidador;
    carreraId: number;
    carrera: Carrera;
    yearInicioId: number;
    monthInicioId: number;
    yearTerminoId: number;
    monthTerminoId: number;
}

export class Idioma
{
    Id: number;
    idioma: string;
}

export class Nivel {
    Id: number;
    nivel: string;
}

export class PerfilIdioma {
    Id: number;
    IdiomaId: number;
    idioma: Idioma;
    nivelId: number;
    nivel: Nivel;
    perfilCandidatoId: number;
}