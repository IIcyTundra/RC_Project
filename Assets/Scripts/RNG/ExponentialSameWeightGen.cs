using System;

public class ExponentialSameWeightGen : WeightGenerator
{
    private float[] _weights;
    public float[] Weights { get => Normalize(_weights); set => _weights = value; }
    public Func<float[], float[]> Normalize { get; set; }
    private float SameBias;
    public ExponentialSameWeightGen(float[] weights, Func<float[], float[]> normalize, float sameBias)
    {
        this.Weights = weights;
        this.Normalize = normalize;
        this.SameBias = sameBias;
    }

    public void Choose(int choice)
    {
        _weights[choice] = _weights[choice] * SameBias;
    }

    public void Reset()
    {
        Array.Fill(_weights, 1);
        Weights = Normalize(Weights);
    }
}
