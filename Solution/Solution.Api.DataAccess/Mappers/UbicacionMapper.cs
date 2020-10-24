using Solution.Api.Business.Models;
using Solution.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Api.DataAccess.Mappers
{
    public static class UbicacionMapper
    {
        public static UBICACION Map(UbicacionModel dto)
        {
            return new UBICACION()
            {
                PersonaID = dto.id,
                UbicacionLatitud = dto.latitud,
                UbicacionLongitud = dto.longitud,
                EmpresaID= dto.idemp,
                UbicacionObservaciones=dto.obs
                
            };
        }
        public static UbicacionModel Map(UBICACION dto)
        {
            return new UbicacionModel()
            {
                id = dto.PersonaID,
                latitud = dto.UbicacionLatitud,
                longitud = dto.UbicacionLongitud,
                idemp = dto.EmpresaID,
                obs = dto.UbicacionObservaciones


            };
        }

    }
}
