using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode;
internal static class DataFetcher
{

    private static readonly HttpClient _httpClient = new HttpClient();
    public static async Task<string> FetchDataForDay(int day)
    
    {
        try
        {
            _httpClient.BaseAddress = new Uri($"https://icanhazdadjoke.com/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var result = await _httpClient.GetAsync("");
            return result.StatusCode.ToString();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }
}
