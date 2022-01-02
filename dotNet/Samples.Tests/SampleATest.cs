using System;
using CognitiveComplexityOnStackOverflow;
using FluentAssertions;
using Xunit;

namespace Samples.Tests
{
    public class SampleATest
    {
        [Fact]
        public void NoFieldSeparatorFound()
        {
            var sut = new SampleA();
            sut.FindDelimiter("").Should().Be('\0');
        }

        [Fact]
        public void FindsFirstCharacter_forDefaultCase()
        {
            var sut = new SampleA();
            sut.FindDelimiter("Some word").Should().Be('S');
        }

        [Fact]
        public void FindsTabFieldSeparator()
        {
            var sut = new SampleA();
            sut.FindDelimiter("\\t").Should().Be('\t');
        }

        [Fact]
        public void FindsUnicodeSeparator()
        {
            var sut = new SampleA();
            sut.FindDelimiter("0").Should().Be('\0');
        }
    }
}
