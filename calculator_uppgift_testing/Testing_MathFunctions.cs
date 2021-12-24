using System;
using Xunit;
using static calculator_uppgift.MathFunctions;

namespace calculator_uppgift_testing
{
    public class Testing_MathFunctions
    {
        
        [Theory]
        [InlineData (90, 45, 45)]
        [InlineData (91, 45, 46)]
        [InlineData (92, 46, 46)]
        [InlineData (100,50, 50)]
        [InlineData (96, 50, 46)]
        [InlineData (4,  50, -46)]
        [InlineData (-4, -50, 46)]
        [InlineData (-96, -50, -46)]
        [InlineData (-101, -50, -51)]
        [InlineData (97, 50.5, 46.5)]
        [InlineData (97.1, 50.8, 46.3)]
        [InlineData (-97.1, -50.8, -46.3)]
        [InlineData (4.5, 50.8, -46.3)]
        [InlineData (97.01, 50.6645, 46.35)]
        [InlineData(-4.5, -50.8, 46.3)]
        [InlineData (-46.3, 0, -46.3)]
        [InlineData (0, 0, 0)]
        
        public void TestAddNumbersTheory(double Expected, Double Value1, double value2)
        {
            double result = Math.Round(AddNumbers(Value1, value2), 2);
            Assert.Equal(Expected, result,2);
            
        }

        [Theory]
        [InlineData(135, new double[] {45,45,45 })]
        [InlineData(45, new double[] { 45, 45, -45 })]
        [InlineData(-45, new double[] { 45, -45, -45 })]
        [InlineData(-135, new double[] { -45, -45, -45 })]
        [InlineData(90, new double[] { 45, 45, 0 })]
        [InlineData(89, new double[] { 45, -1, 45 })]
        [InlineData(96, new double[] { 00, 101, -5 })]
        public void TestAddNumbersFromArrayTheory(double Expected, double [] InputArray)
        {
            double result = Math.Round(AddNumbers(InputArray), 2);
            Assert.Equal(Expected, result, 2);

        }

        [Theory]
        [InlineData(-135, new double[] { 45, 45, 45 })]
        [InlineData(-45, new double[] { 45, 45, -45 })]
        [InlineData(45, new double[] { 45, -45, -45 })]
        [InlineData(135, new double[] { -45, -45, -45 })]
        [InlineData(-90, new double[] { 45, 45, 0 })]
        [InlineData(-89, new double[] { 45, -1, 45 })]
        [InlineData(-96, new double[] { 00, 101, -5 })]
        public void TestSubtractNumbersFromArrayTheory(double Expected, double[] InputArray)
        {
            double result = Math.Round(SubtractNumbers(InputArray), 2);
            Assert.Equal(Expected, result, 2);

        }

        [Theory]
        [InlineData(0, 45, 45)]
        [InlineData(-1, 45, 46)]
        [InlineData(0, 46, 46)]
        [InlineData(1, 50, 49)]
        [InlineData(4, 50, 46)]
        [InlineData(96, 50, -46)]
        [InlineData(-96, -50, 46)]
        [InlineData(-4, -50, -46)]
        [InlineData(1, -50, -51)]
        [InlineData(4, 50.5, 46.5)]
        [InlineData(4.5, 50.8, 46.3)]
        [InlineData(-4.5, -50.8, -46.3)]
        [InlineData(97.1, 50.8, -46.3)]
        [InlineData(4.31, 50.6645, 46.35)]
        [InlineData(-97.1, -50.8, 46.3)]
        [InlineData(46.3, 0, -46.3)]
        [InlineData(0, 0, 0)]

        public void TestSubtractNumbersTheory(double Expected, Double Value1, double value2)
        {
            double result = Math.Round(SubtractNumbers(Value1, value2), 2);
            Assert.Equal(Expected, result, 2);

        }

        [Theory]
        [InlineData(2025, 45, 45)]
        [InlineData(-2300, 50, -46)]
        [InlineData(-2300, -50, 46)]
        [InlineData(2300, -50, -46)]
        
        [InlineData(2348.25, 50.5, 46.5)]
        [InlineData(2352.04, 50.8, 46.3)]
        [InlineData(2352.04, -50.8, -46.3)]
        [InlineData(-2352.04, 50.8, -46.3)]
        [InlineData(2348.3, 50.6645, 46.35)]
        
        [InlineData(0, 0, -46.3)]
        [InlineData(0, 0, 0)]

        public void TestMultiplyNumbersTheory(double Expected, Double Value1, double value2)
        {
            double result = Math.Round(MultiplyNumbers(Value1, value2), 2);
            Assert.Equal(Expected, result, 2);

        }

        [Theory]
        [InlineData(1, 45, 45)]
        [InlineData(-1.09, 50, -46)]
        [InlineData(-0.92, 46, -50)]
        [InlineData(0.92, -46,-50)]

        [InlineData(1.09, 50.5, 46.5)]
        [InlineData(1.1, 50.8, 46.3)]
        [InlineData(1.1, -50.8, -46.3)]
        
        [InlineData(0, 0, -46.3)]
        [InlineData(0, 0, 0)]

        public void TestDivideNumbersTheory(double Expected, Double Value1, double value2)
        {
            double result = Math.Round(DivideNumbers(Value1, value2),2);
            Assert.Equal(Expected, result, 2);

        }



        ////[Fact]
        ////public void TestAddNumbers()
        ////{
        ////   double result =  AddNumbers(45,45);
        ////    Assert.Equal(90, result);

        ////}
        ///
    }
}
