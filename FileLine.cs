namespace TextFileGenerator
{
    internal sealed class FileLine
    {
        public int LineNumber { get; set; }
        public string? LineText { get; set; }

        public override string ToString()
        {
            return $"{LineNumber}. {LineText}";
        }
    }
}