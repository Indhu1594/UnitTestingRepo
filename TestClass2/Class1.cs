using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;

namespace triangleclasstest
{
    public class Class1triangle
    {
        [Test]
        public void validTriangle_Input60and60and60_OutputValidTriangle()
        {
//Indhu's Test
            //Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 90;
            //Act
            string expected ="The triangle is valid.";
            string actual=Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
