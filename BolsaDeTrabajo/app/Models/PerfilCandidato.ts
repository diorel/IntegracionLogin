export class PerfilCandidato
{
    id: number;
    candidatoId: number;
    aboutMeId: number;
    aboutMe: AboutMe[];
    formaciones: Formacion[];
    cursos: Curso[];
    idiomas: PerfilIdioma[];
    conocimientos: ConocimientoOHabilidad[];
    experiencias: ExperienciaProfesional[];
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

export class PerfilExperiencia {
    Id: number;
    perfilExperiencia: string;
}
export class AreaExperiencia {
    Id: number;
    areaExperiencia: string;
}

export class AreaInteres {
    Id: number;
    areaInteres: string;
}

export class AboutMe {
    Id: number;
    acercaDeMi: string;
    puestoDeseado: string;
    salarioAceptable: number;
    salarioDeseado: number;
    perfilExperienciaId: number;
    perfilExperiencia: PerfilExperiencia;
    areaExperienciaId: number;
    areaExperiencia: AreaExperiencia;
    areaInteresId: number;
    areaInteres: AreaInteres;
}

export class Curso {
    id: number;
    curso: string;
    perfilCandidatoId: number;
    institucionEducativaId: number;
    institucionEducativa: InstitucionEducativa;   
    yearInicioId: number;
    monthInicioId: number;
    yearTerminoId: number;
    monthTerminoId: number;
}

export class ConocimientoOHabilidad {
    id: number;
    conocimiento: string;
    herramienta: string;
    perfilCandidatoId: number;
    institucionEducativaId: number;
    institucionEducativa: InstitucionEducativa;
    nivelId: number;
    nivel: Nivel;    
}

export class ExperienciaProfesional {
    id: number;
    empresa: string;
    giroEmpresaId: number;
    cargoAsignado: string;
    areaId: number;
    area: Area;
    yearInicioId: number;
    monthInicioId: number;
    yearTerminoId: number;
    monthTerminoId: number;
    salario: number;
    descripcion: string;
    trabajoActual: boolean;
}

export class Area {
    id: number;
    nombre: string;
}