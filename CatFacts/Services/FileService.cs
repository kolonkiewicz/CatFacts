using System.Runtime.CompilerServices;

namespace CatFacts.Services;

public class FileService : IFileService
{
    private readonly string _filepath;

    public FileService(IWebHostEnvironment environment)
    {
        _filepath = Path.Combine(environment.ContentRootPath, "catfacts.txt");
    }

    public async Task AppendFactAsync(
        string fact,
        int length
    )
    {
        var line = $"Length: {length} | {fact}{Environment.NewLine}";

        await File.AppendAllTextAsync(_filepath,line);

        Console.WriteLine("AppendFactAsync END");

    }

    
}