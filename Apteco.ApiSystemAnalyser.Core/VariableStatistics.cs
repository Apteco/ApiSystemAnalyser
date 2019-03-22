using System;
using Apteco.ApiSystemAnalyser.Core.Utilities;

namespace Apteco.ApiSystemAnalyser.Core
{
  public class VariableStatistics
  {
    #region public properties
    public string SystemName { get; set; }
    public int NumberOfVariables { get; set; }
    public int NumberOfSelectors { get; set; }
    public int TotalNumberOfVarCodes { get; set; }
    public double MedianCodesPerVariable { get; set; }
    public long TotalCodeSize { get; set; }
    public double MedianCodeSizePerVariable { get; set; }

    public double MeanCodesPerVariable => TotalNumberOfVarCodes / (double)NumberOfSelectors;
    public double MeanCodeSizePerVariable => TotalCodeSize / (double)MedianCodeSizePerVariable;

    #endregion

    #region public methods
    public override string ToString()
    {
      double maximumValue = MathsUtilities.Max(NumberOfVariables, NumberOfSelectors,
        TotalNumberOfVarCodes, MeanCodesPerVariable, MedianCodesPerVariable, 
        TotalCodeSize, MeanCodeSizePerVariable, MedianCodeSizePerVariable);

      int maxStringLength = maximumValue.ToString("N0").Length;

      return $"System                            {SystemName}" + Environment.NewLine +
             Environment.NewLine +
             $"Number of variables               {PadNumber(NumberOfVariables, maxStringLength)}" + Environment.NewLine +
             $"  Of which selectors              {PadNumber(NumberOfSelectors, maxStringLength)}" + Environment.NewLine +
             Environment.NewLine +
             $"Varcodes " + Environment.NewLine +
             $"  Total                           {PadNumber(TotalNumberOfVarCodes, maxStringLength)}" + Environment.NewLine +
             $"  Mean codes per variable         {PadNumber(MeanCodesPerVariable, maxStringLength)}" + Environment.NewLine +
             $"  Median codes per variable       {PadNumber(MedianCodesPerVariable, maxStringLength)}" + Environment.NewLine +
             Environment.NewLine +
             $"  Total number of code chars      {PadNumber(TotalCodeSize, maxStringLength)}" + Environment.NewLine +
             $"  Mean code chars per variable    {PadNumber(MeanCodeSizePerVariable, maxStringLength)}" + Environment.NewLine +
             $"  Median code chars per variable  {PadNumber(MedianCodeSizePerVariable, maxStringLength)}" + Environment.NewLine;
    }
    #endregion

    #region private methods
    private string PadNumber(double n, int totalLength)
    {
      string nString = n.ToString("N0");
      return new string(' ', totalLength - nString.Length) + nString;
    }
    #endregion
  }
}
