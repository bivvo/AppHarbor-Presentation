using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Should;

namespace QADAppharborDemo.Tests
{
    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase]
        public void Given_a_simple_demo_when_true_equals_true_then_we_should_pass_the_test()
        {
            true.ShouldBeTrue();
        }

    }
}
