using Solution.Api.Business.Models;
using Solution.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Api.DataAccess.Mappers
{
    public static class EmpresaMapper
    {
        public static EMPRESA Map(EmpresaModel dto)
        {
            return new EMPRESA()
            {
                EmpresaID = dto.EmpresaID,
                EmpresaNombre = dto.EmpresaNombre,
                EmpresaEstado = dto.EmpresaEstado
            };
        }
        public static EmpresaModel Map(EMPRESA dto)
        {
            return new EmpresaModel()
            {
                EmpresaID = dto.EmpresaID,
                EmpresaNombre = dto.EmpresaNombre,
                EmpresaEstado = dto.EmpresaEstado
            };
        }
    }
}
