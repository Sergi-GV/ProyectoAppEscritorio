using AppFaltasEscritorio.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppFaltasEscritorio
{
    public class Negocio
    {
        private readonly HttpClient _httpClient;
        private readonly string url = "http://localhost:8080";

        public Negocio()
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> GetAsync<T>(string breakpoint)
        {
            var response = await _httpClient.GetAsync($"{url}/{breakpoint}");
            
            if(response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                T objeto = JsonConvert.DeserializeObject<T>(data);
                return objeto;
            }
            throw new Exception("Error en la conexión");
        }

        public async Task<T> LoginAsync<T>(string usuario, string contra)
        {
            StringContent content = new StringContent("");
            content.Headers.Add("user", usuario);
            content.Headers.Add("pswd", contra);

            var response = await _httpClient.PostAsync($"{url}/loginAdmin", content);

            if(response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                T objeto = JsonConvert.DeserializeObject<T>(data);
                return objeto;
            }
            return default;
        }

        public async Task<T> PostAsync<T>(string breakpoint, T objeto, string apikey)
        {
            var json = JsonConvert.SerializeObject(objeto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.Add("key", apikey);

            var response = await _httpClient.PostAsync($"{url}/{breakpoint}", content);
            return default;
        }

        public async Task<T> PutAsync<T>(string breakpoint, T objeto, int id, string apikey)
        {
            breakpoint = string.Format(breakpoint, id);
            var json = JsonConvert.SerializeObject(objeto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.Add("key", apikey);

            var response = await _httpClient.PostAsync($"{url}/{breakpoint}", content);
            return default;
        }
    }
}
