using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repositories
{
    public class PersonaRepository : GenericRepository<Persona>, IPersona
    {
        private readonly WebApiContext _context;
    
        public PersonaRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}