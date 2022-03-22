using CommandLine;
using CreateFile;

Parser.Default.ParseArguments<Options>(args)
    .WithParsed(FilesGenerator.GenerateFiles);

Console.Read();