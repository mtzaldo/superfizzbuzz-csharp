using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperFizzBuzz {
    public class SuperFizzBuzz {
        private IRange _range = null;
        private Dictionary<int, string> _replacements = null;

        public SuperFizzBuzz(IRange range, Dictionary<int, string> replacements) {
            _range = range;
            _replacements = replacements;
        }

        public IEnumerable<string> Get() {

            Func<int, string, Func<int, string>> 
                fizzBuzzClosure = (replaceNumber, replaceValue) => 
                    number => number % replaceNumber == 0? replaceValue : string.Empty;

            var fizzBuzzDelegates = _replacements.Select(rep => fizzBuzzClosure(rep.Key, rep.Value));

            return 
                _range.GetValues()
                    .Select(n => new {
                        Number = n,
                        FizzBuzz = fizzBuzzDelegates.Aggregate(string.Empty, (word, fizzBuzz) => word + fizzBuzz(n))
                    })
                    .Select(result =>
                            string.IsNullOrEmpty(result.FizzBuzz)?
                                result.Number.ToString() :
                                result.FizzBuzz);
        }
    }
}