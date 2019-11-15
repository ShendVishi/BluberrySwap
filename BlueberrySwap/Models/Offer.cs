using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Offer
{
	public Offer()
	{

    }

    public int id { get; set; }
    public int buyer_id { get; set; }
    public int seller_id { get; set; }
    public int product_id { get; set; }
    public int offered_product_id { get; set; } //can be null
    public int offered_product_quantity { get; set; }
    public double cash_value_offered { get; set; } //can be null

}
