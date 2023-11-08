using System;
using UnityEngine;

public class BasicNumberGenerator : WeightedNumberGenerator
{
    private WeightGenerator _weightGen;
    public int Min { get; set; }
    public int Max { get; protected set; }
    public WeightGenerator WeightGen { get => _weightGen; set => _weightGen = value; }

    public BasicNumberGenerator(WeightGenerator weights, int min, int max)
    {
        this._weightGen = weights;
        this.Min = min;
        if (min + weights.Weights.Length-1 != max)
        {
            throw new ArgumentException("the weight generator does not generate the correct number of weights");
        }
        this.Max = max;
    }

    public int Generate()
    {
        float accum = UnityEngine.Random.value;
        for (int i = 0; i < _weightGen.Weights.Length; i++)
        {
            accum -= _weightGen.Weights[i];
            if (accum <= 0) {
                _weightGen.Choose(i);
                return i+Min;
            }
        }
        return -1;
    }

    public void Reset()
    {
        _weightGen.Reset();
    }
}
