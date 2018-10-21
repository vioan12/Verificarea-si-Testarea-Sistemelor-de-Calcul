using System;
using NUnit.Framework;
using Lab1;

namespace Lab1Tests
{
    [TestFixture]
    public class Tests
    {
        private string[] testDates;
        private InputProcessing inputProcessing;
        private QuadraticEquation quadraticEquation;
        private string[] testSolution;
        
        [Test]
        public void Test1()
        {
            testDates = new string[3]
            {
                "5", "-2", "10"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            Assert.That(() => quadraticEquation.SolveWithRealSolutions(), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("the equation do not have a real solution")
            );
        }
        
        [Test]
        public void Test2()
        {
            testDates = new string[3]
            {
                "-30", "-50", "0"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "-1.66", "0"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
        
        [Test]
        public void Test3()
        {
            testDates = new string[2]
            {
                "-30", "11"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("b out of range")
            );
        }
        
        [Test]
        public void Test4()
        {
            testDates = new string[3]
            {
                "20", "0", "-1"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("c out of range")
            );
        }
        
        [Test]
        public void Test5()
        {
            testDates = new string[1]
            {
                "-1.00"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("a is not integer")
            );
        }
        
        [Test]
        public void Test6()
        {
            testDates = new string[2]
            {
                "20", "-11.65"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("b is not integer")
            );
        }
        
        [Test]
        public void Test7()
        {
            testDates = new string[3]
            {
                "14", "6", "gogu"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("c is not integer")
            );
        }
        
        [Test]
        public void Test8()
        {
            testDates = new string[1]
            {
                "Y"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("a is not integer")
            );
        }
        
        [Test]
        public void Test9()
        {
            testDates = new string[2]
            {
                "22", "453g"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("b is not integer")
            );
        }
        
        [Test]
        public void Test10()
        {
            testDates = new string[3]
            {
                "3", "0", "31s"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("c is not integer")
            );
        }
        
        [Test]
        public void Test11()
        {
            testDates = new string[3]
            {
                "0", "3", "4"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("The 'a' coefficient cannot equal 0")
            );
        }
        
        [Test]
        public void Test12()
        {
            testDates = new string[3]
            {
                "1", "0", "10"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            Assert.That(() => quadraticEquation.SolveWithRealSolutions(), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("the equation do not have a real solution")
            );
        }
        
        [Test]
        public void Test13()
        {
            testDates = new string[3]
            {
                "-1", "6", "18"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "-2.19", "8.19"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
        
        [Test]
        public void Test14()
        {
            testDates = new string[3]
            {
                "11", "-27", "0"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "2.45", "0"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
        
        [Test]
        public void Test15()
        {
            testDates = new string[3]
            {
                "-12", "10", "0"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "0", "0.83"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
        
        [Test]
        public void Test16()
        {
            testDates = new string[3]
            {
                "2", "-14", "24"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "4", "3"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
        
        [Test]
        public void Test17()
        {
            testDates = new string[1]
            {
                ""
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);  
            Assert.That(() => quadraticEquation = new QuadraticEquation(inputProcessing.GetData()), Throws.Exception.TypeOf<Exception>().With.Message.EqualTo
                ("a is not integer")
            );
        }
        
        [Test]
        public void Test18()
        {
            testDates = new string[3]
            {
                "1", "4", "4"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "-2", "-2"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
        
        [Test]
        public void Test19()
        {
            testDates = new string[3]
            {
                "70", "-50", "0"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "0.71", "0"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
        
        [Test]
        public void Test20()
        {
            testDates = new string[3]
            {
                "8", "-30", "7"
            };
            inputProcessing = new InputProcessing(new InputTest(testDates), null);
            quadraticEquation = new QuadraticEquation(inputProcessing.GetData());
            testSolution = new string[2]
            {
                "3.5", "0.25"
            };
            Assert.AreEqual(Decimals.Round(quadraticEquation.SolveWithRealSolutions(),2), testSolution);
        }
    }
}