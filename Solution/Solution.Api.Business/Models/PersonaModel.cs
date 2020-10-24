using Solution.Api.DataAccess.Contracts.Entities;
using Solution.Api.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Api.Business.Models
{
    public class PersonaModel
    {
        public int PersonaID { get; set; }
        public string PersonaNombre { get; set; }
        public string PersonaApelliso { get; set; }
        public string PersonaNroDocumento { get; set; }
        public int EmpresaID { get; set; }
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual TIPODOCUMENTO TIPODOCUMENTO { get; set; }
        public virtual ICollection<UBICACION> UBICACION { get; set; }


    }
}
