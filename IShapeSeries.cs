using System;
using System.Collections.Generic;
using System.Text;

namespace task8.Interface
{
    internal interface IShapeSeries 
    {
      int CurrentShapeArea { get; set; } 
      void GetNextArea(); 
      void ResetSeries(); 
    }
}
