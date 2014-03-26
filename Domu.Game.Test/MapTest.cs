using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domu.Game.Test
{
    [TestFixture]
    class MapTest
    {
        [Test]
        [ExpectedException(typeof(Exception))]
        public void SetupInitialMap_InitialState_Exception()
        {
            var map = new Map();
            map.SetupInitialMap();


        }
    }
}
