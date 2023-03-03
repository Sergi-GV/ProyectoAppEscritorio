
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentanasProyectoFaltas.Modelo;

namespace AppFaltasEscritorio
{
    public static class Herramientas
    {
        public static async Task<List<guardias>> GetGuardiasAsync()
        {
            Negocio negocio = new Negocio();
            List<guardias> listaGuardias = await negocio.GetAsync<List<guardias>>("guardias");

            return listaGuardias;
        }

        public static async Task<List<profesores>> LoginAdmin(string user, string pswd)
        {
            Negocio negocio = new Negocio();
            List<profesores> profesor = await negocio.LoginAsync<List<profesores>>(user, pswd);

            return profesor;
        }

        public static async Task<guardias> ModificarGuardiaAsync(guardias guardiaModificada, string apikey)
        {
            Negocio negocio = new Negocio();
            guardias guardia = await negocio.PutAsync("modificar-guardia/{id}", guardiaModificada, guardiaModificada.Id, apikey);

            return guardia;
        }

        public static async Task<guardias> AnularGuardiaAsync(guardias guardiaModificada, string apikey)
        {
            Negocio negocio = new Negocio();
            guardias guardia = await negocio.PutAsync("anular-guardia/{id}", guardiaModificada, guardiaModificada.Id, apikey);

            return guardia;
        }
    }
}
