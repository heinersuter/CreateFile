# CreateFile

CreateFile is a command line application to create dummy files with a defined size.

## Type of application / build

.Net 6.0 application

## Command line usage

    dotnet CteateFile.dll [-c <count>] [-s <size>] [-u <unit>] [-n <name>]

    -c, --count    Number of files to be generated.
    -s, --size     Size of one file.
    -u, --unit     Unit of file size.
    -n, --name     Name[pattern] of file.
    --help         Display this help screen.
    --version      Display version information.
    
Example:

    notnet CreateFile.dll -c 2 -s 3 -u MegaMytes

Creates 2 files, each 3 MB.
