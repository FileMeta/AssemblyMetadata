# AssemblyMetadata

This is a [CodeBit](http://www.filemeta.org/CodeBit.html) that facilitates retrieval of a .NET assembly's metadata. It works in .NET Framework and .NET Core.

## Use

Download [AssemblyMetadata.cs](https://github.com/FileMeta/AssemblyMetadata/raw/main/AssemblyMetadata.cs) and add it to your project.

Use one of the two constructors to create an AssemblyMetadata instance. Many web tutorials and StackOverflow posts recommend calling [GetExecutingAssembly()](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly.getexecutingassembly), [GetCallingAssembly()](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly.getcallingassembly?view=net-5.0), or [GetEntryAssembly()](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly.getentryassembly). But, depending on circumstances, they may not return the assembly you want or expect. And, depending on circumstances, `GetEntryAssembly()` may not work.

Instead, choose a class that belongs to the assembly for which you want information. When reporting the version number of the _application_, I use the `Program` class like this:

```
var appMetadata = new AssemblyMetadata(typeof(Program));

Console.WriteLine(appMetadata.Summary);
```

## Pending Enhancements

* Make this a _real_ unit test that compares the retrieved metadata values against the expected values.
* Access .NET Core attributes such as `Project URL`, `Repository URL`, `Tags`, `Release Notes` and so forth.