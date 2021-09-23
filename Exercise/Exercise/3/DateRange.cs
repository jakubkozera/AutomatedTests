namespace Exercise
{
    public class DateRange
    {
        public DateRange(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
