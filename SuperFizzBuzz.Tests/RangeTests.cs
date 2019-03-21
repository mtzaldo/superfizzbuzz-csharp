using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;

namespace SuperFizzBuzz.Tests
{
    [TestClass]
    public class RangeTests
    {
        [TestMethod]
        public void Range_GetValues_should_return_the_correct_number_of_values() {
            var expectedCount = 10;

            var range = new Range(1, 10);

            var result = range.GetValues().ToList();

            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void Range_GetValues_should_return_one_value() {
            var expectedCount = 1;

            var range = new Range(0, 0);

            var result = range.GetValues().ToList();

            Assert.AreEqual(expectedCount, result.Count);
        }

        public void Range_GetValues_should_return_the_expected_values() {
            var expectedLength = 10;

            var range = new Range(1, 10);

            var results = range.GetValues().ToList();

            for(int i = 0; i < expectedLength; i++) {
                Assert.AreEqual(i + 1, results[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Range_constructor_should_throw_ArgumentException_when_start_is_greater_than_end() {

            var range = new Range(10, 1);
        }
    }
}
