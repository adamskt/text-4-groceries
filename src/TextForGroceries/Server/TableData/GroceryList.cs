using Azure;
using Azure.Data.Tables;
using TextForGroceries.Shared.Models;

namespace TextForGroceries.Server.TableData;

public class GroceryList : IGroceryList, ITableEntity
{
    public GroceryList(string owner, string shopper, string partitionKey, string rowKey)
    {
        Owner = owner;
        Shopper = shopper;
        PartitionKey = partitionKey;
        RowKey = rowKey;
        CreationDateTime ??= DateTimeOffset.UtcNow;
    }

    public DateTimeOffset? CreationDateTime { get; init; }
    public string Owner { get; init; } 
    public string Shopper { get; init; }
    public bool IsComplete { get; set; }
    public DateTimeOffset? CompletionDateTime { get; set; }
    public (string Name, string Notes, bool IsShopped)[] ListItems { get; set; } =
        Array.Empty<(string, string, bool)>();
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}