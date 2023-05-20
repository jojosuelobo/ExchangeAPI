using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exer3
{
    internal class Metodos
    {
        public Metodos()
        {
            
        }

        public void Exibir(ApiResponse resposta)
        {
            ExibirDefault(resposta);
            //ExibirInput(resposta);
        }

        public void ExibirDefault(ApiResponse resposta)
        {
            Console.WriteLine($"Status da consulta: {(resposta.Result).Replace("success", "Sucesso!")}");
            Console.WriteLine($"Data da consulta: {TratarData(resposta.Time_last_update_utc)} \n");
            Console.WriteLine($"Moeda: {resposta.Base_code}");
            //Console.WriteLine($"Taxa de câmbio em relação ao real brasileiro (BRL): { resposta.Conversion_rates.BRL} ");
            Console.WriteLine($"Taxa de câmbio em relação ao real brasileiro (BRL): {Math.Round((resposta.Conversion_rates.BRL), 2)} ");

            //Console.WriteLine($"Taxa de câmbio em relação ao euro (EUR): {resposta.Conversion_rates.EUR}");
            Console.WriteLine($"Taxa de câmbio em relação ao euro (EUR): {Math.Round((resposta.Conversion_rates.EUR), 2)}");

            //Console.WriteLine($"Taxa de câmbio em relação ao iene japonês (JPY): {resposta.Conversion_rates.JPY}");
            Console.WriteLine($"Taxa de câmbio em relação ao iene japonês (JPY): {Math.Round((resposta.Conversion_rates.JPY), 2)}");
        }
        public string TratarData(string data)
        {
            // Fri, 19 May 2023 00:00:01 +0000
            data = data.Substring(0, data.IndexOf("00:")); // Fri, 19 May 2023

            // "Traduzir" os dias da semana para Português
            data = data.Replace("Mon", "Segunda").Replace("Tue", "Terça").Replace("Wed", "Quarta").Replace("Thu", "Quinta").Replace("Fri", "Sexta").Replace("Sat", "Sábado").Replace("Sun", "Domingo");
            // Fri, 19 May 2023 => Sexta, 19 May 2023

            // "Traduzir" o mês
            data = data.Replace("May", "de Maio,").Replace("Jun", "de Junho,");

            return data;
        }

    }
}
