using Bogus;

namespace TextFileGenerator
{
    internal sealed class FileLineFaker : Faker<FileLine>
    {
        public FileLineFaker()
        {
            var random = new Random();
            UseSeed(random.Next())
                .RuleFor(c => c.LineNumber, f => f.Random.Number(1, 1000000))
                .RuleFor(c => c.LineText, f => f.Lorem.Sentence());
        }

        public FileLine GetLine()
        {
            return Generate(1).Single();
        }
    }
}