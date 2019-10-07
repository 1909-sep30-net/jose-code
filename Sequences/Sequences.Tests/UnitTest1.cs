using System;
using Xunit;
using Sequences.Library;
using System.Text;
using System.Collections.Generic;


namespace Sequences.Tests
{
    public class StringSequenceTests
    {
  
        [Theory]
        [InlineData("abc")]
        public void AddShouldAdd()
        {   
            //arrange (any setup necessary to prepare for the behavior to test
            var seq = new StringSequence();
            //act do the thing you want to test
            seq.Add("abc");
            //assert  (verify that the behavior was as expected)
            Assert.Equal(expected: "abc", actual: seq[0]);
        }

        [Fact]
        public void AddShouldAddInConsistentOrder()
        {
            var seq = new StringSequence();

            seq.Add("abc");
            seq.Add("def");

            Assert.Equal(expected: "abc", actual: seq[0]);
            Assert.Equal(expected: "def", actual: seq[1]);
        }

        [Fact]
        public void AccessOutOfBoundsShouldThrow()
        {
            var seq = new StringSequence();
            var x = seq[0];

        }
    }


}
