using System;
using System.Collections.Generic;
using System.Text;
using task8.Interface;

namespace task8
{
    internal class SquareSeries : IShapeSeries 
    { 
        public int CurrentShapeArea { get; set; } 
        private int side = 0; 
        public void GetNextArea() { side++; CurrentShapeArea = side * side; } 
        public void ResetSeries() { side = 0; CurrentShapeArea = 0; } 
    }
}
