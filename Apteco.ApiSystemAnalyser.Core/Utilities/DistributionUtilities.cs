using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apteco.ApiSystemAnalyser.Core.Utilities
{
  public static class DistributionUtilities
  {
    #region public methods
    public static double GetMedian(IEnumerable<double> values)
    {
      IList<double> sortedValues = values.OrderBy(n => n).ToList();
      return GetMedianFromSortedValues(sortedValues);
    }

    public static double GetMedianFromSortedValues(IList<double> sortedValues)
    {
      return GetCentileFromSortedValues(sortedValues, 50);
    }

    public static double GetCentileFromSortedValues(IList<double> sortedValues, int centile)
    {
      int valuesCount = sortedValues.Count;

      if (valuesCount == 0)
        return double.NaN;

      if (valuesCount == 1)
        return sortedValues[0];

      //https://stackoverflow.com/questions/8137391/percentile-calculation
      double n = (valuesCount - 1) * (centile / 100.0) + 1;

      if (n == valuesCount)
      {
        return sortedValues[valuesCount - 1];
      }
      else
      {
        int k = (int)n;
        double d = n - k;
        return sortedValues[k - 1] + d * (sortedValues[k] - sortedValues[k - 1]);
      }
    }
    #endregion
  }
}
