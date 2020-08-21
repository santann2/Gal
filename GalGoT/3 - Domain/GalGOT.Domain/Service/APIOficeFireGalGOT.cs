using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using GalGOT.Domain.Entites;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using GalGOT.Domain.Util;

namespace GalGOT.Domain.Service
{
    public class APIOficeFireGalGOT
    {
        private const string URL = "https://anapioficeandfire.com/api/characters/";

        public List<Personagem> GetLord(string idlord)
        {
            idlord = "";
            var tPersonagem = new List<Personagem>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(idlord).Result;


            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;

                foreach (var d in dataObjects)
                {

                }
            }
            else
            {
                var ret = string.Concat("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return tPersonagem;
        }
    }
}
