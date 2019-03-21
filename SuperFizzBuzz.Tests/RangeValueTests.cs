using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;

namespace SuperFizzBuzz.Tests
{
    [TestClass]
    public class RangeValueTests
    {
        [TestMethod]
        public void RangeValue_GetValues_should_return_the_correct_number_of_values() {
            var values = Enumerable.Range(1, 10).ToArray();

            var range = new RangeValue(values);

            var result = range.GetValues().ToList();

            Assert.AreEqual(values.Length, result.Count);
        }

        [TestMethod]
        public void Range_GetValues_should_return_zero_values() {
            var values = new int[0];

            var expectedCount = 0;

            var range = new RangeValue(values);

            var result = range.GetValues().ToList();

            Assert.AreEqual(expectedCount, result.Count);
        }

        public void RangeValue_GetValues_should_return_the_same_values() {
            var values = new int[] { 1, 5, 10000, -1, -22, 44, 200, 24, 24, 24 };

            var range = new RangeValue(values);

            var results = range.GetValues().ToList();

            for(int i = 0; i < values.Length; i++) {
                Assert.AreEqual(values[i], results[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RangeValue_constructor_should_throw_ArgumentException_when_value_is_null() {

            var range = new RangeValue(null);
        }
    }
}
