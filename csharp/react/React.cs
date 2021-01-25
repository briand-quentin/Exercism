using System;
using System.Collections.Generic;
using System.Linq;

public class Reactor
{
    public InputCell CreateInputCell(int value)
    {
        return new InputCell()
        {
            Value = value
        };
    }

    public ComputeCell CreateComputeCell(IEnumerable<Cell> producers, Func<int[], int> compute)
    {
        compute();
    }
}

public abstract class Cell
{
    public int Value;
}

public class InputCell : Cell
{
}

public class ComputeCell : Cell
{
   
    public EventHandler<int> Changed;
}