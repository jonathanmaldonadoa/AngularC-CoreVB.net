using Solution.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Api.Business.Models
{
    public class UbicacionModel
    {
        public int id { get; set; }
        public int idemp { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public string obs { get; set; }

    }

}
