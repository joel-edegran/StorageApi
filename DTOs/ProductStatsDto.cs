namespace StorageApi.DTOs;

public class ProductStatsDto
{
    public int TotalProducts { get; set; }
    public int TotalInventoryValue { get; set; }
    public double AveragePrice { get; set; }
}
