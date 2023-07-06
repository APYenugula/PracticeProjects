namespace webapisample1.Models
{
    public class timerclass : Itimerclass
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
