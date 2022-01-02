using System;
using FluentAssertions;
using Xunit;

namespace Samples.Tests
{
    public class SampleATest
    {
        [Fact]
        public void Foo()
        {
            false.Should().Be(true);
        }
    }
}
