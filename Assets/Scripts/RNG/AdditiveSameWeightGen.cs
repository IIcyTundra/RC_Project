using System;

public class AdditiveSameNumberGen : WeightGenerator
{
    private float[] _weights;
    public float[] Weights { get => Normalize(_weights); set => _weights = value; }
    public Func<float[], float[]> Normalize { get; set; }
    public readonly float sameBias;
    public AdditiveSameNumberGen(float[] weights, float sameBias)
    {
        this.Weights = weights;
        this.sameBias = sameBias;
    }

    public AdditiveSameNumberGen( float sameBias )
    {
        this.sameBias = sameBias;
    }

    public void Reset()
    {
        Array.Fill(_weights, 1);
        _weights = Normalize(_weights);
    }

    public void Choose(int choice)
    {
        _weights[choice] = Math.Abs(_weights[choice] + sameBias);
        _weights = Normalize(Weights);
    }
}
