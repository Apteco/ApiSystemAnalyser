using System;

namespace Apteco.ApiSystemAnalyser.Core.Utilities
{
  public static class MathsUtilities
  {
    #region public methods
    public static double Max(params double[] values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof(values));

      if (values.Length == 0)
        throw new ArgumentException("At least one value must be specified", nameof(values));

      if (values.Length == 1)
        return values[0];

      double runningMaximum = double.NaN;
      for (int i = 1; i < values.Length; i++)
      {
        if (i == 1)
          runningMaximum = Math.Max(values[i - 1], values[i]);
        else
          runningMaximum = Math.Max(runningMaximum, values[i]);
      }

      return runningMaximum;
    }
    #endregion
  }
}
