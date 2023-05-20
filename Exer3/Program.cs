using Refit;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Exer3
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            try
            {
                var ApiClient = RestService.For<IApiResponse>("https://v6.exchangerate-api.com");
                await Console.Out.WriteLineAsync();

                var resposta = await ApiClient.GetDataAsync();

                Metodos metodos = new Metodos();
                metodos.Exibir(resposta);

            } catch (Exception ex)
            {
                Console.WriteLine("Erro na consulta!: " + ex.Message);
            }
        }
    }
}
