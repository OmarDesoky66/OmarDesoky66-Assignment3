namespace CSharpBasicsAssignment;

internal class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;


    /// <summary>
    /// computes TotalPrice from Quantity, UnitPrice, and DiscountPercent (e.g. Quantity ×
    ///UnitPrice × (1 − Discount/100)) and stores the result back into the TotalPrice field.
    /// </summary>
    public void CalculateTotal()
    {
        TotalPrice = Quantity * UnitPrice *
                     (decimal)(1 - DiscountPercent / 100);
    }

    /// <summary>
    /// prints a one-line summary of the order, including at minimum OrderId, CustomerName,
    ///TotalPrice, and IsPaid.
    /// </summary>
    public void PrintSummary()
    {
        Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Total: {TotalPrice}, Paid: {IsPaid}");
    }
}
