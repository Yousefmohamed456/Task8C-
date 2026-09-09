using System;
using System.Collections.Generic;
using System.Text;
using task8.Interface;

namespace task8
{
    internal class CircleSeries : IShapeSeries 
    { 
        public int CurrentShapeArea { get; set; } 
        private int radius = 0; 
        public void GetNextArea() { 
            radius++; 
            CurrentShapeArea = (int)(Math.PI * radius * radius); 
        } 
        public void ResetSeries() {
            radius = 0; 
            CurrentShapeArea = 0; 
        } 
    }
}
