namespace WorstCropygraphEver
{
    internal static class TokenGenerator
    {
        /// <summary>
        /// Generates a super duper secure token
        /// </summary>
        /// <returns>Super safety!</returns>
        public static string GenerateToken()
        {
            Random random = new Random();
            byte[] tokenData = new byte[32];
            random.NextBytes(tokenData);
            return Convert.ToBase64String(tokenData);
        }
    }
}
