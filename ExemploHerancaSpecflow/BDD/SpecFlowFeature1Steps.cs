using System;
using TechTalk.SpecFlow;
using Calculadora;
using NUnit.Framework;

namespace NUnitTestProject2
{
    [Binding]
    public class SpecFlowFeature1Steps : Common_Steps
    {

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calc.Add(p0);
        }
        
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, resultado);
        }
    }
}
