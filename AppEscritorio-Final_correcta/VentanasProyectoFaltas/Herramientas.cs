
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

        public static async Task<List<profesores>> GetProfesoresAsync()
        {
            Negocio negocio = new Negocio();
            List<profesores> listaProfes = await negocio.GetAsync<List<profesores>>("profesores");

            return listaProfes;
        }

        public static async Task<guardias> ObtenerGuardiaPorId(int id)
        {
            Negocio negocio = new Negocio();
            guardias guardia = await negocio.GetAsync<guardias>($"guardia/{id}");

            return guardia;
        }

        public static async Task<List<profesores>> LoginAdmin(string user, string pswd)
        {
            Negocio negocio = new Negocio();
            List<profesores> profesor = await negocio.LoginAsync<List<profesores>>(user, pswd);

            return profesor;
        }

        public static async Task CrearGuardiaAsync(string breakpoint, avisos_guardia g, string apikey)
        {
            Negocio negocio = new Negocio();
            await negocio.PostAsync(breakpoint, g, apikey);
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
        public static async Task<profesores> ObtenerProfesorPorId(int id)
        {
            Negocio negocio = new Negocio();
            profesores profesor = await negocio.GetAsync<profesores>($"profesores/{id}");

            return profesor;
        }
    }
}
