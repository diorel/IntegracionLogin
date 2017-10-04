export class MunettFormat {    
    
    paternal_surname: string;
    mothers_maiden_name: string;
    names: string;
    sex: string;
    birthdate: string;
    entity_birth: string;
    options: options= new options();

}

export class options {
    rfc: boolean;
    nss: boolean;
}