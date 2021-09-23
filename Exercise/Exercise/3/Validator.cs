using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Validator
    {
        /// <summary>
        /// Returns true value if the input date ranges are not overlapping
        /// </summary>
        /// <returns></returns>
        public bool ValidateOverlapping(List<DateRange> dateRanges, DateRange input)
        {
            if (dateRanges == null || !dateRanges.Any()) return true;


            var overlappingDateRange = dateRanges
                .FirstOrDefault(dr => input.From.Date >= dr.From.Date && input.From.Date <= dr.To.Date
                                    || input.To.Date >= dr.From.Date && input.To.Date <= dr.To.Date);

            if (overlappingDateRange != null) return false;


            var outerOverlappingDateRange = dateRanges
                .FirstOrDefault(dr => dr.From.Date <= input.From.Date && dr.To.Date >= input.To.Date);

            if (outerOverlappingDateRange != null) return false;


            var innerOverlappingDateRange = dateRanges
                .FirstOrDefault(dr => dr.From.Date <= input.To.Date && dr.From.Date >= input.From.Date
                 && dr.To.Date <= input.To.Date && dr.To.Date >= input.From.Date);

            
            if(innerOverlappingDateRange != null) return false;

            return true;
        }
    }
}
