
invoices
========
Logic for creating and editing invoices

![Build Status](https://mindpowered.dev/assets/images/github-badges/build-passing.svg)

Contents
========

* [Source Code and Documentation](#source-code-and-documentation)
* [Licensing](#licensing)
* [Requirements](#requirements)
* [Installation](#installation)
* [Usage](#usage)
* [Support](#support)

# Source Code and Documentation
- Source Code: [https://github.com/mindpowered/invoices-csharp](https://github.com/mindpowered/invoices-csharp)
- Documentation: [https://mindpowered.github.io/invoices-csharp](https://mindpowered.github.io/invoices-csharp)

# Licensing
To obtain a version of this package under the MIT License, follow the instructions to [get a license][purchase]. The MIT License has no restrictions on commercial use and permits reuse within proprietary software.

# Requirements
## To import pre-compiled library
- nuget

## To build from source
- Visual Studio Build Tools
- Haxe 4.1.1
- Neko
- hxcs Haxelib
- nuget


Third-party dependencies may have additional requirements.

# Installation
## NuGet

nuget ...

## MSBuild

Add the following entry to your .csproj file:

```
<PackageReference Include="mindpowered.invoices" Version="0.0.3" />
```


# Usage
```csharp
global::mindpowered.invoices.Invoices inv = new global::mindpowered.invoices.Invoices();
inv.Create("354", "2153", "2021-02-01", "2021-03-01", "Thanks for the business!");
```


# Support
We are here to support using this package. If it doesn't do what you're looking for, isn't working, or you just need help, please [Contact us][contact].

There is also a public [Issue Tracker][bugs] available for this package.



[bugs]: https://github.com/mindpowered/invoices-csharp/issues
[contact]: https://mindpowered.dev/support.html?ref=invoices-csharp/
[docs]: https://mindpowered.github.io/invoices-csharp/
[licensing]: https://mindpowered.dev/?ref=invoices-csharp
[purchase]: https://mindpowered.dev/purchase/
