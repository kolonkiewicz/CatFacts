namespace CatFacts.Services;

public interface IFileService
{
    Task AppendFactAsync(string fact, int length);
}