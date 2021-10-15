using ClientiService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AcademyG.TestWeek6.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Prove
            GestioneOrdiniServiceClient client = new GestioneOrdiniServiceClient();

            List<Cliente> clients = await client.FetchAllClientsAsync();

            foreach (Cliente c in clients)
                Console.WriteLine($"{c.Id} - {c.CodiceCliente} " +
                    $"{c.Nome} {c.Cognome}\n");

            HttpClient clientWeb = new HttpClient();

            HttpRequestMessage httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44325/api/ordini")
            };

            Console.WriteLine("Lista ordini");

            HttpResponseMessage httpResponse = await clientWeb.SendAsync(httpRequest);

            if (httpResponse.IsSuccessStatusCode)
            {
                string jsonData = await httpResponse.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<OrdineContract>>(jsonData);

                foreach (var item in results)
                    Console.WriteLine($"[{item.Id}] {item.CodiceOrdine} {item.CodiceProdotto} {item.Importo}");
            }

            Console.WriteLine("Premi un tasto");
            Console.ReadKey();


            #endregion
            //Non ho fatto in tempo a completarlo perché nell'ultima parte stavo rispondendo
            //alle domande di teoria però i test che mancano qua li ho fatti con Visual studio
            //per WCF e Swagger per WebAPI
        }
    }
}
