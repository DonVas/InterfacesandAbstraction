namespace Telephony
{
    using System.Linq;

    public class Phone : ICaller, IBrowser
    {
        public string Browsing(string url)
        {
            return url.Any(char.IsDigit) ? "Invalid URL!" : $"Browsing: {url}!";
        }

        public string Calling(string number)
        {
            return number.All(char.IsDigit) ?  $"Calling... {number}" : "Invalid number!";
        }
    }
}
