using D20240408.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20240408.AccesoADatos
{
    public class PersonaDDAL
    {
        readonly ApplicationDbContext _context;

        public PersonaDDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        //Crear
        public async Task<int> Crear(PersonaD personaD)
        {
            _context.Add(personaD);
            return await _context.SaveChangesAsync();
        }

        //Modificar
        public async Task<int> Modificar(PersonaD personaD)
        {
            var personaDData = await _context.PersonasD.FirstOrDefaultAsync(s => s.Id == personaD.Id);

            if (personaDData != null)
            {
                personaDData.NombreD = personaD.NombreD;
                personaDData.ApellidoD = personaD.ApellidoD;
                personaDData.FechaNacimientoD = personaD.FechaNacimientoD;
                personaDData.SueldoD = personaD.SueldoD;
                personaDData.EstatusD = personaD.EstatusD;
                personaDData.ComentarioD = personaD.ComentarioD;
                _context.Update(personaDData);
            }

            return await _context.SaveChangesAsync();
        }

        //Eliminar
        public async Task<int> Eliminar(PersonaD personaD)
        {
            var personaDData = await _context.PersonasD.FirstOrDefaultAsync(s => s.Id == personaD.Id);

            if (personaDData != null)
            {
                _context.Remove(personaDData);
            }

            return await _context.SaveChangesAsync();
        }

        //Obtener por Id
        public async Task<PersonaD> ObtenerPorId(PersonaD personaD)
        {
            var personaDData = await _context.PersonasD.FirstOrDefaultAsync(s => s.Id == personaD.Id);
            if (personaDData != null)
                return personaDData;
            else
                return new PersonaD();
        }


        //Obtener Todos
        public async Task<List<PersonaD>> ObtenerTodos()
        {
            return await _context.PersonasD.ToListAsync();
        }

        //Buscar
        public async Task<List<PersonaD>> Buscar(PersonaD personaD)
        {

            var query = _context.PersonasD.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaD.NombreD))
            {
                query = query.Where(s => s.NombreD.Contains(personaD.NombreD));
            }
            if (!string.IsNullOrWhiteSpace(personaD.ApellidoD))
            {
                query = query.Where(s => s.ApellidoD.Contains(personaD.ApellidoD));
            }
            return await query.ToListAsync();
        }
    }
}
