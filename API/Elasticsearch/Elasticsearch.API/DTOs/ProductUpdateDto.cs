namespace Elasticsearch.API.DTOs
{
    public record ProductUpdateDto(string id, string Name, decimal Price, int stock, ProductFeatureDto Feature)
    {
    }
}
