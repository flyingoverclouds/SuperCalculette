using NuGet.Frameworks;
using NUnit.Framework.Constraints;

namespace SuperMathTests
{
    public class MathTests
    {

        SuperMath.Math calculette=null;

        [SetUp]
        public void Setup()
        {
            calculette=new SuperMath.Math();
        }

        [Test]
        public void TestAdd()
        {
            Assert.That(calculette.Add(0, 0), Is.EqualTo(0));
            Assert.That(calculette.Add(1, 1), Is.EqualTo(2));
            Assert.That(calculette.Add(int.MaxValue, int.MinValue), Is.EqualTo(-1));
            Assert.That(calculette.Add(int.MaxValue, int.MaxValue), Is.EqualTo(-2));
        }

        [Test]
        public void TestDiv()
        {
            Assert.That(calculette.Div(1, 1), Is.EqualTo(1));
            Assert.That(calculette.Div(0, 1), Is.EqualTo(0));
            Assert.That(() => calculette.Div(1, 0), Throws.ArgumentException);
        }

        [Test]
        public void ValeurDePi()
        {
            Assert.That(calculette.Pi(), Is.EqualTo(System.Math.PI));
        }


    }
}