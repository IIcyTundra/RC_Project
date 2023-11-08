using System;

public interface WeightGenerator
{
    public float[] Weights { get; }
    /* this is important for making assumptions about the output weights */
    public Func<float[], float[]> Normalize { get; set; }
    /* for dynamic weight generators Reset() makes the weights uniform.
     * for the static ones it does nothing */
    public void Reset();
    public void Choose(int choice);
}
