namespace CreateFile;

internal static class FilesGenerator
{
    public static void GenerateFiles(Options options)
    {
        for (var i = 0; i < options.Count; i++)
        {
            var filename = GenerateFilename(options, i);
            var size = options.Size * Math.Pow(1024, (int)options.SizeUnit);
            GenerateFile(filename, (long)size, options.Mode);
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

    private static void GenerateFile(string filename, long size, Mode mode)
    {
        switch (mode)
        {
            case Mode.Empty:
                GenerateEmptyFile(filename, size);
                break;
            case Mode.Random:
                GenerateRandomFile(filename, size);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
        }
    }

    private static void GenerateEmptyFile(string filename, long size)
    {
        using var fs = new FileStream(filename, FileMode.Create);
        fs.Seek(size, SeekOrigin.Begin);
        fs.WriteByte(0);
    }

    private static void GenerateRandomFile(string filename, long size)
    {
        var data = new byte[1024];
        var random = new Random();
        using var stream = File.OpenWrite(filename);
        for (var i = 0; i < size / 1024; i++)
        {
            random.NextBytes(data);
            stream.Write(data, 0, data.Length);
        }
    }
}