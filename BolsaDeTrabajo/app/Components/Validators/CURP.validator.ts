import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

import { ValidacionIdentificaciones } from '../../Services/ValidacionIdentificaciones.service';

import { IPalabraInconveniente } from '../../Models/IPalabraInconveniente';
import { IValidState } from '../../Models/IValidState';
import { MunettFormat, options } from '../../Models/munettFormat'; 
import { IEstado } from '../../Models/IEstado';


@Component({
    templateUrl: '/app/Components/alta.candidato.component.html'
})
export class CURPValidator {
    Nombres: string[]=new Array(4);
    Nombre: string;
    Paterno: string;
    Materno: string;
    FechaNacimiento: Date;
    EstadoNacimiento: string;
    Sexo: string;

    munett: MunettFormat = new MunettFormat();
    
    CURP: string;
    RFC: string;
    Letra: string;
    CURPValida: string = '';
    RFCValida: string = '';
    Sustituto: IPalabraInconveniente;

    constructor(private service: ValidacionIdentificaciones) {

    }

    ValidarIMSS(fechaNacimiento: Date, imss:string)
    {
        if (imss.length < 6) {
            return;
        }
        this.FechaNacimiento = fechaNacimiento;
        let _fecha = fechaNacimiento.toDateString();
        let fecha = _fecha.split(' ');
        console.log(imss.substr(4, 2));
        console.log(fecha[3]);
        if (imss.substr(4, 2) == fecha[1].substr(1, 2))
            return true;

        return false;
    }
    public ValidarCurp(nombre: string, paterno: string, materno: string, fechaNacimiento: Date, sexo: string, estadoNacimiento: IEstado, curp: string) {

        if (curp == null || curp == '')
        {
            return;
        }
        this.Nombre = this.FormatearNombre(nombre.toUpperCase());
        this.Paterno = this.FormatearPaterno(paterno.toUpperCase());
        this.Materno = this.FormatearMaterno(materno.toUpperCase());

        this.FechaNacimiento = fechaNacimiento;
        let _fecha = fechaNacimiento.toDateString();
        let fecha = _fecha .split(' ');
        this.CURPValida = '';
        this.CURPValida += this.PosicionUno();
        this.CURPValida += this.PosicionDos();
        this.CURPValida += this.PosicionTres();
        this.CURPValida += this.PosicionCuatro();
        this.CURPValida = this.PalabraInconveniente(this.CURPValida);
        this.CURPValida += fecha[3].substr(2, 2) + this.meses(fecha[1]) + fecha[2];
        this.CURPValida += sexo == "1" ? "H" : "M";
        this.CURPValida += estadoNacimiento.clave;
        this.CURPValida += this.Posicion141516(this.Paterno);
        this.CURPValida += this.Posicion141516(this.Materno);
        this.CURPValida += this.Posicion141516(this.Nombre);
        this.CURP = curp.toUpperCase();
    

        if (this.CURPValida == this.CURP.substr(0, 16))
        {
            if (parseInt(fecha[2]) < 2000)
            {
               
                if (!this.IsDigit(this.CURP.substr(16, 1)))
                {
                    return false
                }
            } else {
                if (!this.IsLetra(this.CURP.substr(16, 1))) {
                    return false
                }
            }

            return true;
        }
        return false;
    }

    public ValidarRFC(nombre: string, paterno: string, materno: string, fechaNacimiento: Date, sexo: string, estadoNacimiento: IEstado, rfc: string) {

        if (rfc == null || rfc == '') {
            return;
        }
        this.Nombre = this.FormatearNombre(nombre.toUpperCase());
        this.Paterno = this.FormatearPaterno(paterno.toUpperCase());
        this.Materno = this.FormatearMaterno(materno.toUpperCase());

        this.FechaNacimiento = fechaNacimiento;
        let _fecha = fechaNacimiento.toDateString();
        let fecha = _fecha.split(' ');
        this.RFCValida = '';
        this.RFCValida += this.PosicionUno();
        this.RFCValida += this.PosicionDos();
        this.RFCValida += this.PosicionTres();
        this.RFCValida += this.PosicionCuatro();
        this.RFCValida = this.PalabraInconveniente(this.RFCValida);
        this.RFCValida += fecha[3].substr(2, 2) + this.meses(fecha[1]) + fecha[2];
        this.RFC = rfc.toUpperCase();
        console.log(this.RFCValida);
        console.log(this.RFC)
        console.log(this.RFC.substr(0, 10))
        if (this.RFCValida == this.RFC.substr(0, 10)) {
           
            return true;
        }
        return false;
    }
    public meses(mes: string)
    {
        switch (mes)
        {
            case "Jan":
                return "01";
            case "Feb":
                return "02";
            case "Mar":
                return "03";
            case "Apr":
                return "04";
            case "May":
                return "05";
            case "Jun":
                return "06";
            case "Jul":
                return "07";
            case "Aug":
                return "08";
            case "Sep":
                return "09";
            case "Oct":
                return "10";
            case "Nov":
                return "11";
            case "Dic":
                return "12";
        }
    }

    

    private PosicionUno()    //primera letra del primer apellido
    {
        if ("Ñ" == this.Paterno.substr(0, 1))
            return "X";
                   
        return this.Paterno.substr(0, 1)
    }
    
    private PosicionDos()//primera vocal interna del primer apellido
    {
        const regex = /[AEIOU]/g;
        let str = this.Paterno.substr(1, this.Paterno.length);
        let m;
        let matches: string[] = new Array(str.length);
        let index: number = 0;

        while ((m = regex.exec(str)) !== null) {
            // This is necessary to avoid infinite loops with zero-width matches
            if (m.index === regex.lastIndex) {
                regex.lastIndex++;
            }

            // The result can be accessed through the `m`-variable.
            m.forEach((match, groupIndex) => {
               // console.log(`Found match, group ${groupIndex}: ${match}`);
                matches[index] = match;
                index++;
            });
        }
        //console.log(matches);
        if (matches[0] != null && matches[0] != '')
            return matches[0];
        
        return "X";
    }

    private PosicionTres() {
        if ("Ñ" == this.Materno.substr(0, 1))
            return "X";

        return this.Materno.substr(0, 1) ;
    }

    private PosicionCuatro()//primera letra del nombre de pila
    {
        return this.Nombre.substr(0, 1);
    }

    private FormatearNombre(nombre: string) {
        this.Nombres = nombre.split(" ");
        let nombreNormalizado: string;
        for (var i = 0; i < this.Nombres.length; i++) {
            nombreNormalizado = this.Normalizar(this.Nombres[i])
            if (!(this.NombresComunes(nombreNormalizado) && this.EvitarCompuestos(nombreNormalizado))) {
                return nombreNormalizado;
            }
        }
        return nombre[0]; 
    }

    private FormatearPaterno(paterno: string) {
        var paternoCompuesto = paterno.split(" ");
        let paternoNormalizado: string;
        for (var i = 0; i < paternoCompuesto.length; i++) {
            paternoNormalizado = this.Normalizar(paternoCompuesto[i])
            if (!(this.EvitarCompuestos(paternoNormalizado))) {
                return paternoNormalizado;
            }
        }
        return paternoCompuesto[0]; 
    }

    private FormatearMaterno(materno: string) {
        if (materno == null || materno == '')
        {
            return "X"; 
        }  
        var maternoCompuesto = materno.split(" ");
        let maternoNormalizado: string;
        for (var i = 0; i < maternoCompuesto.length; i++) {
            maternoNormalizado = this.Normalizar(maternoCompuesto[i])
            if (!(this.EvitarCompuestos(maternoNormalizado))) {
                return maternoNormalizado;
            }
        }
        return maternoCompuesto[0];    
    }

   

    public PalabraInconveniente(str: string) {
        var inconvenientes = ['BACA', 'LOCO', 'BUEI', 'BUEY', 'MAME', 'CACA', 'MAMO',
            'CACO', 'MEAR', 'CAGA', 'MEAS', 'CAGO', 'MEON', 'CAKA', 'MIAR', 'CAKO', 'MION',
            'COGE', 'MOCO', 'COGI', 'MOKO', 'COJA', 'MULA', 'COJE', 'MULO', 'COJI', 'NACA',
            'COJO', 'NACO', 'COLA', 'PEDA', 'CULO', 'PEDO', 'FALO', 'PENE', 'FETO', 'PIPI',
            'GETA', 'PITO', 'GUEI', 'POPO', 'GUEY', 'PUTA', 'JETA', 'PUTO', 'JOTO', 'QULO',
            'KACA', 'RATA', 'KACO', 'ROBA', 'KAGA', 'ROBE', 'KAGO', 'ROBO', 'KAKA', 'RUIN',
            'KAKO', 'SENO', 'KOGE', 'TETA', 'KOGI', 'VACA', 'KOJA', 'VAGA', 'KOJE', 'VAGO',
            'KOJI', 'VAKA', 'KOJO', 'VUEI', 'KOLA', 'VUEY', 'KULO', 'WUEI', 'LILO', 'WUEY',
            'LOCA'];

        if (inconvenientes.indexOf(str) > -1) {
            str = str.replace(str.substr(1, 1), 'X')
        }

        return str;
    }

    public NombresComunes(str: string) {
        var comunes = ['MARIA', 'JOSE', 'MA', 'J', ' ' ];

        if (comunes.indexOf(str) > -1) {
            return true;
        }

        return false;
    }

    public Normalizar(str: string) {
       var origen = ['Ã', 'À', 'Á', 'Ä', 'Â', 'È', 'É', 'Ë', 'Ê', 'Ì', 'Í', 'Ï', 'Î',
            'Ò', 'Ó', 'Ö', 'Ô', 'Ù', 'Ú', 'Ü', 'Û', 'ã', 'à', 'á', 'ä', 'â',
            'è', 'é', 'ë', 'ê', 'ì', 'í', 'ï', 'î', 'ò', 'ó', 'ö', 'ô', 'ù',
            'ú', 'ü', 'û', 'Ç', 'ç'];
        var destino = ['A', 'A', 'A', 'A', 'A', 'E', 'E', 'E', 'E', 'I', 'I', 'I', 'I',
            'O', 'O', 'O', 'O', 'U', 'U', 'U', 'U', 'a', 'a', 'a', 'a', 'a',
            'e', 'e', 'e', 'e', 'i', 'i', 'i', 'i', 'o', 'o', 'o', 'o', 'u',
            'u', 'u', 'u', 'c', 'c'];
        var strs = str.split('');
        var salida = strs.map(function (char) {
            var pos = origen.indexOf(char);
            return (pos > -1) ? destino[pos] : char;
        }).toString();

        return salida;
    }

    public EvitarCompuestos(str: string) {
        var compuestos = ['DA', 'DAS', 'DE', 'DEL', 'DER', 'DI',
            'DIE', 'DD', 'EL', 'LA', 'LOS', 'LAS', 'LE',
            'LES', 'MAC', 'MC', 'VAN', 'VON', 'Y'];
        if (compuestos.indexOf(str)) {
            return true;
        }
        return false;
    }

    public Posicion141516(string:string)//primera consonante no interna del primer apellido, segundo apellido y nombre
    {
        const regex = /[QWRTYPSDFGHJKLZXCVBNM]/g;
        let str = string.substr(1, this.Paterno.length);
        let m;
        let matches: string[] = new Array(str.length);
        let index: number = 0;

        while ((m = regex.exec(str)) !== null) {
            // This is necessary to avoid infinite loops with zero-width matches
            if (m.index === regex.lastIndex) {
                regex.lastIndex++;
            }

            // The result can be accessed through the `m`-variable.
            m.forEach((match, groupIndex) => {
                //console.log(`Found match, group ${groupIndex}: ${match}`);
                matches[index] = match;
                index++;
            });
        }
        //console.log(matches);
        if (matches[0] != null && matches[0] != '')
            return matches[0];

        return "X";
    }

    IsLetra(digito: any)
    {
        const regex = /[QWERTYUIOPASDFGHJKLZXCVBNM]/g;
        let str = digito;
        let m;
        let matches: string[] = new Array(str.length);
        let index: number = 0;

        while ((m = regex.exec(str)) !== null) {
            // This is necessary to avoid infinite loops with zero-width matches
            if (m.index === regex.lastIndex) {
                regex.lastIndex++;
            }

            // The result can be accessed through the `m`-variable.
            m.forEach((match, groupIndex) => {
                //console.log(`Found match, group ${groupIndex}: ${match}`);
                matches[index] = match;
                index++;
            });
        }
        //console.log(matches);
        if (matches[0] != null && matches[0] != '')
            return true;

        return false;
    }

    IsDigit(digito: any) {
        const regex = /[1234567890]/g;
        let str = digito;
        let m;
        let matches: string[] = new Array(str.length);
        let index: number = 0;

        while ((m = regex.exec(str)) !== null) {
            // This is necessary to avoid infinite loops with zero-width matches
            if (m.index === regex.lastIndex) {
                regex.lastIndex++;
            }

            // The result can be accessed through the `m`-variable.
            m.forEach((match, groupIndex) => {
                //console.log(`Found match, group ${groupIndex}: ${match}`);
                matches[index] = match;
                index++;
            });
        }
        //console.log(matches);
        if (matches[0] != null && matches[0] != '')
            return true;

        return false;
    }

 
}

