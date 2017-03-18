using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using MyPCL;
using NUnit.Framework;


namespace UnitTests
{
    [TestFixture]
    public class UniversalUnitTests
    {
        private StubIService _service;

        private List<string> _data = new List<string>
        {
            "Hello",
            "world",
            "this",
            "is",
            "me"
        };

        [SetUp]
        public void Setup()
        {
            _service = new StubIService();
            _service.GetData(number => _data.Take(number).ToList());
        }


        [TearDown]
        public void Tear() { }

        [Test]
        public void Pass()
        {
            var SUT = new MyClass(_service);

            var result = SUT.GetCities();

            Assert.False(result.Any());
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }

        [Test]
        public void Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }
}