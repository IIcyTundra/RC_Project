public interface WeightedNumberGenerator
{
    public int Generate();
    /* Max and Min SHOULD behave as readonly */
    public WeightGenerator WeightGen { get; set; }
    public int Min { get; }
    public int Max { get; }
    public void Reset();
}
