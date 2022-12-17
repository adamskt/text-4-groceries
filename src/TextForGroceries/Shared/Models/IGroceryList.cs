namespace TextForGroceries.Shared.Models;

public interface IGroceryList
{
    public DateTimeOffset? CreationDateTime { get; init; }
    public string Owner { get; init; }
    public string Shopper { get; init; }
    public bool IsComplete { get; set; }
    public DateTimeOffset? CompletionDateTime { get; set; }
    public (string Name, string Notes, bool IsShopped)[] ListItems { get; set; }
}

