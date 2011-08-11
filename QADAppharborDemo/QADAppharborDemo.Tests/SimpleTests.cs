using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Should;

namespace QADAppharborDemo.Tests
{
    [TestFixture]
    public class Given_a_simple_demo
    {
        [TestCase]
        public void When_true_equals_true_Then_we_should_pass_the_test()
        {
            true.ShouldBeTrue();
        }

    }
}
