using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Solution.Api.DataAccess.Contracts.Entities
{
    public class PERSONA
    {
        [Key]

        public int PersonaID { get; set; }
        public string PersonaNombre { get; set; }
        public string PersonaApelliso { get; set; }
        public string PersonaNroDocumento { get; set; }
        public int EmpresaID { get; set; }
        [JsonIgnore]
        public virtual EMPRESA EMPRESA { get; set; }
        public int TipoDocumentoID { get; set; }
        [JsonIgnore]
        public virtual TIPODOCUMENTO TIPODOCUMENTO { get; set; }
        public virtual ICollection<UBICACION> UBICACION { get; set; }

    }
}
