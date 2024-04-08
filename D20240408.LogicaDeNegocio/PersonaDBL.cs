using D20240408.AccesoADatos;
using D20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20240408.LogicaDeNegocio
{
    public class PersonaDBL
    {
        readonly PersonaDDAL _personaDDAL;

        public PersonaDBL(PersonaDDAL personaDDAL)
        {
            _personaDDAL = personaDDAL;
        }


        //Crear
        public async Task<int> Crear(PersonaD personaD)
        {
            return await _personaDDAL.Crear(personaD);
        }

        //Modificar
        public async Task<int> Modificar(PersonaD personaD)
        {
            return await _personaDDAL.Modificar(personaD);
        }

        //Eliminar
        public async Task<int> Eliminar(PersonaD personaD)
        {
            return await _personaDDAL.Eliminar(personaD);
        }

        //Obtener por Id
        public async Task<PersonaD> ObtenerPorId(PersonaD personaD)
        {
            return await _personaDDAL.ObtenerPorId(personaD);
        }

        //Obtener Todos
        public async Task<List<PersonaD>> ObtenerTodos()
        {
            return await _personaDDAL.ObtenerTodos();
        }

        //Buscar
        public async Task<List<PersonaD>> Buscar(PersonaD personaD)
        {
            return await _personaDDAL.Buscar(personaD);
        }
    }
}
