namespace SCA_API.Classes
{
    public static class Utils
    {
        public static string GetCompressPercentage(byte[] original, byte[] compressed)
        {
            return string.Format("{0:P2}", 1 - (double)compressed.Length / original.Length);
        }
    }
}
