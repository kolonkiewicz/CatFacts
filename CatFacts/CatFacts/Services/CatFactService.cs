using System.Net.Http.Json;
using CatFacts.Models;

namespace CatFacts.Services;

public class CatFactService : ICatFactService
{
    private readonly HttpClient _httpClient;
    private readonly ICatFactRepository _repository;
    private readonly IFileService _fileService;

    public CatFactService(
        HttpClient httpClient, 
        ICatFactRepository repository,
        IFileService fileService)
    {
        _httpClient = httpClient;
        _repository = repository;
        _fileService = fileService;
    }

    public async Task<CatFact> GetRandomFactAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<CatFact>(
            "https://catfact.ninja/fact");

        if ( response is null)
        {
            throw new Exception("Could not retrieve cat fact.");
        }

        response.CreatedAt = DateTime.Now;

        await _repository.AddAsync(response);

        await _fileService.AppendFactAsync(response.Fact, response.Length);

        return response;
    }
}