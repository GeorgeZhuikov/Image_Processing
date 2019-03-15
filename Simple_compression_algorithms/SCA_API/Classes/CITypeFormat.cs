namespace SCA_API.Classes
{
    public class CITypeFormat
    {
        public string Type { get; set; }
        public string Format { get; set; }

        public CITypeFormat(string type, string format)
        {
            Type = type;
            Format = format;
        }
    }
}
