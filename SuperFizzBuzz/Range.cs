using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperFizzBuzz
{
    public class Range : IRange
    {
        private int _start = 0;
        private int _end = 0;
        public Range(int start, int end) {

            if (start > end) {
                throw new ArgumentException("start should be less or equal than end");
            }

            _start = start;
            _end = end;
        }

        public IEnumerable<int> GetValues() {

            for(int i = _start; i <= _end; i++) {
                yield return i;
            }
        }
    }
}
