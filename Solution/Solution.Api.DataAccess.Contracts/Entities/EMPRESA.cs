using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Solution.Api.DataAccess.Contracts.Entities
{
    public class EMPRESA
    {
        [Key]
        public int EmpresaID { get; set; }
        public string EmpresaNombre { get; set; }
        public string EmpresaEstado { get; set; }

        [JsonIgnore]
        public virtual ICollection<UBICACION> UBICACION { get; set; }
        [JsonIgnore]
        public virtual ICollection<TIPODOCUMENTO> TIPO_DOCUMENTO { get; set; }
        [JsonIgnore]
        public virtual ICollection<PERSONA> PERSONA { get; set; }
    }
}
