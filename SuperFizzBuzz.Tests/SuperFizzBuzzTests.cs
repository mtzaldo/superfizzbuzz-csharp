using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;

namespace SuperFizzBuzz.Tests
{
    [TestClass]
    public class SuperFizzBuzzTests
    {
        [TestMethod]
        public void SuperFizzBuzz_from_Range_should_return_a_valid_fizzBuzz_result()
        {
            var range = new Range(1, 15);
            var replacements = new Dictionary<int, string>() {
                { 3, "Fizz"},
                { 5, "Buzz"}
            };

            var sfb = new SuperFizzBuzz(range, replacements);

            var result = sfb.Get().ToList();

            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("Fizz", result[2]);
            Assert.AreEqual("4", result[3]);
            Assert.AreEqual("Buzz", result[4]);
            Assert.AreEqual("14", result[13]);
            Assert.AreEqual("FizzBuzz", result[14]);
        }

        [TestMethod]
        public void SuperFizzBuzz_from_RangeValue_should_return_a_valid_fizzBuzz_result() {
            var values = Enumerable.Range(1, 15).ToArray();
            var range = new RangeValue(values);
            var replacements = new Dictionary<int, string>() {
                { 3, "Fizz"},
                { 5, "Buzz"}
            };

            var sfb = new SuperFizzBuzz(range, replacements);

            var result = sfb.Get().ToList();

            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("Fizz", result[2]);
            Assert.AreEqual("4", result[3]);
            Assert.AreEqual("Buzz", result[4]);
            Assert.AreEqual("14", result[13]);
            Assert.AreEqual("FizzBuzz", result[14]);
        }

        [TestMethod]
        public void SuperFizzBuzz_from_RangeValue_should_return_a_valid_fizzBuzz_result_for_random_values() {
            var values = new int[] { 1, 5, 10000, -1, -22, 44, 200, 24, 24, 24 };
            var range = new RangeValue(values);
            var replacements = new Dictionary<int, string>() {
                { 1, "Head"},
                { 2, "Spring"},
                { 24, "Code"}
            };

            var sfb = new SuperFizzBuzz(range, replacements);

            var result = sfb.Get().ToList();

            Assert.AreEqual("Head", result[0]);
            Assert.AreEqual("Head", result[1]);
            Assert.AreEqual("HeadSpring", result[2]);
            Assert.AreEqual("Head", result[3]);
            Assert.AreEqual("HeadSpring", result[4]);
            Assert.AreEqual("HeadSpring", result[5]);
            Assert.AreEqual("HeadSpring", result[6]);
            Assert.AreEqual("HeadSpringCode", result[7]);
            Assert.AreEqual("HeadSpringCode", result[8]);
            Assert.AreEqual("HeadSpringCode", result[9]);
        }

        [TestMethod]
        public void SuperFizzBuzz_from_RangeValue_should_return_a_zero_fizzBuzz_results() {
            var values = new int[0];
            var range = new RangeValue(values);
            var replacements = new Dictionary<int, string>() {
                { 3, "Fizz"},
                { 5, "Buzz"}
            };

            var sfb = new SuperFizzBuzz(range, replacements);

            var result = sfb.Get().ToList();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }
    }
}
