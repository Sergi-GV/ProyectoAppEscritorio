using AppFaltasEscritorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFaltasEscritorio
{
    public static class Herramientas
    {
        public static async Task<List<Guardia>> GetGuardiasAsync()
        {
            Negocio negocio = new Negocio();
            List<Guardia> guardias = await negocio.GetAsync<List<Guardia>>("guardias");

            return guardias;
        }

        public static async Task<List<Profesor>> LoginAdmin(string user, string pswd)
        {
            Negocio negocio = new Negocio();
            List<Profesor> profesor = await negocio.LoginAsync<List<Profesor>>(user, pswd);

            return profesor;
        }

        public static async Task<Guardia> ModificarGuardiaAsync(Guardia guardiaModificada, string apikey)
        {
            Negocio negocio = new Negocio();
            Guardia guardia = await negocio.PutAsync("modificar-guardia/{id}", guardiaModificada, guardiaModificada.id, apikey);

            return guardia;
        }

        public static async Task<Guardia> AnularGuardiaAsync(Guardia guardiaModificada, string apikey)
        {
            Negocio negocio = new Negocio();
            Guardia guardia = await negocio.PutAsync("anular-guardia/{id}", guardiaModificada, guardiaModificada.id, apikey);

            return guardia;
        }
    }
}
