namespace TextFileGenerator
{
    internal static class FileGenerator
    {
        private static string FileName => $"GeneratedFile_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
        private static readonly FileLineFaker _faker = new();    
        public static void GenerateFile(int amountOfLines)
        {
            using (var writer = new StreamWriter(FileName))
            {
                for (int i = 0; i <= amountOfLines; i++)
                {
                    writer.WriteLine(_faker.GetLine().ToString());
                }                
            }
        }
    }
}