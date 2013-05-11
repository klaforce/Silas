﻿#region

using System.Linq;

#endregion

namespace Silas.Forecast
{
    public class SimpleExponentialSmoothingStrategy : IForecastStrategy
    {
        public int Forecast(int[] data)
        {
            return data.Last();
        }
    }
}