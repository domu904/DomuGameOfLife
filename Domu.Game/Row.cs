using System;

namespace Domu.Game
{
    public class Row
    {
        public Cell cell { get; set; }

        public void Setup(int rowSize)
        {
            if(rowSize == 0) throw new IndexOutOfRangeException();
            
            throw new System.NotImplementedException();
        }
    }
}