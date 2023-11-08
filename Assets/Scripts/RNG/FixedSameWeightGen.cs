using System;

class FixedSameWeightGen : WeightGenerator
{
    private float[] _weights;
    private int prevChosen = 0;
    public float[] Weights { get => Normalize(_weights); }

    public Func<float[], float[]> Normalize { get; set; }
    public float SameWeight;
    public float DiffWeight;

    public FixedSameWeightGen(float sameWeight, float diffWeight, int size, Func<float[], float[]> normalize)
    {
        this.SameWeight = sameWeight;
        this.DiffWeight = diffWeight;
        this.Normalize = normalize;
        _weights = new float[size];
        Array.Fill(_weights, diffWeight);
    }

    public void Choose(int choice)
    {
        _weights[prevChosen] = DiffWeight;
        _weights[choice] = SameWeight;
        prevChosen = choice;
    }

    public void Reset()
    {
        _weights[prevChosen] = DiffWeight;
    }
}
