using Solution.Api.Business.Models;
using Solution.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Api.DataAccess.Mappers
{
    public class PersonaMapper
    {
          public static PERSONA Map(PersonaModel dto)
        {
            return new PERSONA()
            {
                EmpresaID = dto.EmpresaID,
                PersonaApelliso = dto.PersonaApelliso,
                PersonaNombre = dto.PersonaNombre,
                PersonaNroDocumento = dto.PersonaNroDocumento,
                EMPRESA = dto.EMPRESA,
                TIPODOCUMENTO =dto.TIPODOCUMENTO,
                UBICACION=dto.UBICACION

            };
        }
        public static PersonaModel Map(PERSONA dto)
        {
            return new PersonaModel()
            {
                EmpresaID = dto.EmpresaID,
                PersonaApelliso = dto.PersonaApelliso,
                PersonaNombre = dto.PersonaNombre,
                PersonaNroDocumento = dto.PersonaNroDocumento,
                EMPRESA=dto.EMPRESA,
                TIPODOCUMENTO= dto.TIPODOCUMENTO,
                UBICACION = dto.UBICACION

            };
        }
    }
}
