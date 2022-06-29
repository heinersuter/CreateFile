using CommandLine;
using CreateFile;

// args = new[] { "-s", "5", "-u", "GigaBytes", "-n", "test-5-GB.pdf" };

Parser.Default.ParseArguments<Options>(args)
    .WithParsed(FilesGenerator.GenerateFiles);
