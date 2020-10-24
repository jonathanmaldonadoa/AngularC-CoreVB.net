using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Solution.Api.DataAccess.Contracts.Entities
{
    public class TIPODOCUMENTO
    {
        [Key]
        public int TipoDocumentoID { get; set; }
        public string TipoDocumentoNombre { get; set; }
        public int EmpresaID { get; set; }
        [JsonIgnore]
        public virtual EMPRESA EMPRESA { get; set; }
        [JsonIgnore]
        public virtual ICollection<PERSONA> PERSONA { get; set; }
    }
}
