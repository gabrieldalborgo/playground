using System;

namespace MathUtils
{
  public class Calculator
  {
    public int Sum(int a, int b)
    {
      return a + b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();
        return a / b;
    }
  }
}