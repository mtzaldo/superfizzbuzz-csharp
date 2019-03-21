using System;
using System.Collections.Generic;

public class RangeValue : IRange
{
    private int[] _values = null;

    public RangeValue(int[] values) {

        if (values is null) {
            throw new ArgumentException("values can't be null");
        }

        _values = values;
    }
    public IEnumerable<int> GetValues()
    {
        foreach(var v in _values) {
            yield return v;
        }
    }
}