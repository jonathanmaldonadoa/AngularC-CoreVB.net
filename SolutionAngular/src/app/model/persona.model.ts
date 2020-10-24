export class PersonaModel

    {
       personaID:number;
       personaNombre:string;
       personaApelliso:string;
       personaNroDocumento:number;
       empresaID:number;
       empresa:string;
       tipodocumento: {
          tipoDocumentoID:number;
          tipoDocumentoNombre:string;
          empresaID:number;
       };
       ubicacion: []
    }
