using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class CiudadDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public int? IdDepartamentoFk { get; set; }
    }
}