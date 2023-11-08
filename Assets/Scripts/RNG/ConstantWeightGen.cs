using System;

public class ConstantWeightGen : WeightGenerator
{
    private float[] _weights;
    public float[] Weights { get => Normalize(_weights); set => _weights = value; }
    public Func<float[], float[]> Normalize { get; set; }

    public ConstantWeightGen(float[] weights, Func<float[], float[]> normalize)
    {
        this.Weights = weights;
        this.Normalize = normalize;
    }

    public void Choose(int choice) { }

    public void Reset() { }
}