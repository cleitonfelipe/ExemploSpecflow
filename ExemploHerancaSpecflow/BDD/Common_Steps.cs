using Calculadora;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTestProject2
{
    public class Common_Steps
    {
        public Calcular calc;
        public int resultado;

        public Common_Steps()
        {
            calc = new Calcular();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            resultado = calc.somar();
        }
    }
}
