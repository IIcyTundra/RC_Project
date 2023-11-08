using System;
using System.Linq;

public class AdditiveCompositeweightGen : WeightGenerator
{
    private WeightGenerator[] _generators;
    public float[] Weights
    {
        get  {
            var temp = _generators.Select(gen => gen.Weights);
            float[] accumulator = new float[_generators[0].Weights.Length];
            foreach (float[] weights in temp)
            {
                for (int i = 0; i < weights.Length; i++)
                {
                    accumulator[i] += weights[i];
                }
            }
            return Normalize(accumulator);
        }
    }
    public Func<float[], float[]> Normalize { get; set; }

    public AdditiveCompositeweightGen(WeightGenerator[] weightGenerators) {
        this._generators = weightGenerators;
    }

    public void Choose(int choice)
    {
        foreach (WeightGenerator gen in _generators)
        {
            gen.Choose(choice);
        }
    }

    public void Reset()
    {
        foreach (WeightGenerator gen in _generators)
        {
            gen.Reset();
        }
    }
}
