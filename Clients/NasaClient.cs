
using System.Net.Http.Json;
using TestApp.Models;

namespace TestApp.Clients;
public class NasaClient{

private readonly HttpClient _client;

public NasaClient(HttpClient client){
    _client = client;
}

public async Task<NasaResponse> getNasa(string date){
    var url = "https://api.nasa.gov/planetary/apod?api_key=lqtEAyeygqklQgc8pi0F5WZy0NPhT9za24XczfuZ";
    if(date != null){
        url = url + "&date=" + date;
    }
    return await _client.GetFromJsonAsync<NasaResponse>(url);

}

}