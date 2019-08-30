# JmesPath .NET unofficial functions

This repository contains unofficial functions for use with [JmesPath.Net](https://github.com/jdevillard/JmesPath.Net/).

## Documentation

Please, consult the [Wiki](https://github.com/springcomp/JmesPath.Net.Functions/wiki)


## Tests

This repository contains a series of tests cases that can be checked using the compliance command-line tool available from the JmesPath.Net repository.

The compliance tool has been updated to allow registering additionnal third-party functions. For this to work, the assembly implementing the extra functions must be put in the same folder as the running executable.

This repository includes the source code of the compliance tool wrapped in a custom projet that copies the functions assembly as a pre-build step.

Simply run the following code:

````
PS > dotnet run --project .\tools\jmespathnet.compliance\jmespathnet.compliance.csproj `
     --register "DevLab.JmesPath.Functions.Registrations, Jmespath.Net.Functions" `
     -t ".\tests\"
````
