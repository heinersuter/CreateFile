namespace CreateFile;

internal static class FilesGenerator
{
    public static void GenerateFiles(Options options)
    {
        for (var i = 0; i < options.Count; i++)
        {
            var filename = GenerateFilename(options, i);
            var size = options.Size * Math.Pow(1024, (int)options.SizeUnit);
            GenerateFile(filename, (long)size);
            Console.WriteLine($"File '{filename}' generated with size '{options.Size} {options.SizeUnit}'.");
        }
    }

    private static string GenerateFilename(Options options, int index)
    {
        if (options.Count > 1)
        {
            return $"{Path.GetFileNameWithoutExtension(options.NamePattern)}-{index}{Path.GetExtension(options.NamePattern)}";
        }

        return options.NamePattern;
    }

    private static void GenerateFile(string filename, long size)
    {
        using var fs = new FileStream(filename, FileMode.Create);
        fs.Seek(size, SeekOrigin.Begin);
        fs.WriteByte(0);
    }
}