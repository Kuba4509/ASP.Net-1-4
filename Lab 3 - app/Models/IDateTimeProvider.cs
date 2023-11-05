namespace Lab_3___app.Models
{
    public interface IDateTimeProvider
    {
        DateTime GetDateTime(); 
    }
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
