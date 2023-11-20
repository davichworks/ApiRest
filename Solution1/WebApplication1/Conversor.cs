

public class Conversor
{

    public int units { get; set; }

    public string fromUnits { get; set; }

    public string toUnits { get; set; }

    public Conversor()
    {
        this.units = 10;
        this.fromUnits = "eur";
        this.toUnits = "usd";
        

    }
}