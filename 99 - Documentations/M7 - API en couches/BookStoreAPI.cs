using Domain.DTO.Requests;
using Domain.DTO.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class BookStoreAPI
{
    private readonly HttpClient _client;
    private string AccessToken;
    public bool IsConnected => !string.IsNullOrEmpty(AccessToken);

    public BookStoreAPI()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri("http://localhost:5171/api/");
      
    }


    public async Task<bool> SignIn(string username, string password)
    {
        var reponse = await _client.PostAsJsonAsync<LoginRequest>("account/login", new LoginRequest() {username = username, password = password });

        if(reponse.IsSuccessStatusCode)
        {
            var responseContent = await reponse.Content.ReadFromJsonAsync<LoginResponse>();
            AccessToken = responseContent.AccessToken;
           
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + AccessToken);
            
            return true;
        }

        return false;
    }


    public async Task<List<Book>> GetBooksAsync() {
      
        try
        {
            var response = await _client.GetFromJsonAsync<List<Book>>("bookstore/books");
            return response;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine(ex.StatusCode);
            return null;
        }   
       
    
    }


}
