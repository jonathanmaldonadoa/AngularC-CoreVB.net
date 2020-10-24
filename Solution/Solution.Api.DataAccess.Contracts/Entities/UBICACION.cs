using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Solution.Api.DataAccess.Contracts.Entities
{
    public class UBICACION
    {
        [Key]
        public int UbicacionID { get; set; }
        public string UbicacionLongitud { get; set; }
        public string UbicacionLatitud { get; set; }
        public string UbicacionObservaciones { get; set; }

        public int PersonaID { get; set; }
        [JsonIgnore]
        public virtual PERSONA PERSONA { get; set; }
        public int EmpresaID { get; set; }
        [JsonIgnore]
        public virtual EMPRESA EMPRESA { get; set; }
    }
}
