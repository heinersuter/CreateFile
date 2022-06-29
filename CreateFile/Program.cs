using CreateFile;

//args = new[] { "-s", "8", "-u", "MegaBytes", "-n", "test-8-MB.pdf", "-m", "Random" };

//Parser.Default.ParseArguments<Options>(args).WithParsed(FilesGenerator.GenerateFiles);

FilesGenerator.GenerateFiles(new Options
{
    Size = 2,
    SizeUnit = SizeUnit.KiloBytes,
    NamePattern = "",
    Mode = Mode.Random,
});
FilesGenerator.GenerateFiles(new Options
{
    Size = 2,
    SizeUnit = SizeUnit.MegaBytes,
    NamePattern = "",
    Mode = Mode.Random,
});
FilesGenerator.GenerateFiles(new Options
{
    Size = 128,
    SizeUnit = SizeUnit.MegaBytes,
    NamePattern = "",
    Mode = Mode.Random,
});
FilesGenerator.GenerateFiles(new Options
{
    Size = 2,
    SizeUnit = SizeUnit.GigaBytes,
    NamePattern = "",
    Mode = Mode.Random,
});
FilesGenerator.GenerateFiles(new Options
{
    Size = 5,
    SizeUnit = SizeUnit.GigaBytes,
    NamePattern = "",
    Mode = Mode.Random,
});
