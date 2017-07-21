using Newtonsoft.Json.Converters;

namespace AazarKhanTelstraSMSAPI.PCL.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}