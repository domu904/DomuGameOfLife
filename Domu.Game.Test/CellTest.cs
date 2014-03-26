using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domu.Game.Test
{
    [TestFixture]
    class CellTest
    {
        [Test]
        [ExpectedException(typeof(Exception))]
        public void Init_Begining_Exception()
        {
            var cell = new Cell();
            cell.Init();
        }
    }
}
