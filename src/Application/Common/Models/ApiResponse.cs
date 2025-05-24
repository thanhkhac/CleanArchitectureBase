namespace CleanArchitectureBase.Application.Common.Models;

public class ApiResponse<T>
{
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    public IDictionary<string, string[]> ValidationErrors { get; set; } = new Dictionary<string, string[]>();
    public T? Data { get; set; }
}
