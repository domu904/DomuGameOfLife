using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domu.Game.Test
{
    [TestFixture]
    class RowTest
    {
        [Test]
        [ExpectedException(typeof(Exception))]
        public void Setup_NoRowValue_NeedToHaveRowValue()
        {
            var row = new Row();
            row.Setup(0);
        }

        [Test]
        public void 

    }
}
