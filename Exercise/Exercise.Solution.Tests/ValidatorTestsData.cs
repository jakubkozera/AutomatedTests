using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Solution.Tests
{
    public class ValidatorTestsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 1), new DateTime(2020, 1, 15)),
                    new DateRange(new DateTime(2020, 2, 1), new DateTime(2020, 2, 15)),
                }
            };
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 15), new DateTime(2020, 1, 25)),
                },
            };
            yield return new object[]
            {
                 new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 8), new DateTime(2020, 1, 25)),
                },
            };
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 12), new DateTime(2020, 1, 14)),
                },
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
