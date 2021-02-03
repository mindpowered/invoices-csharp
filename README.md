
invoices
========
Create, edit, and track invoices as part of your app

![Build Status](https://mindpowered.dev/assets/images/github-badges/build-passing.svg)

Contents
========

* [Source Code and Documentation](#source-code-and-documentation)
* [About](#about)
* [Requirements](#requirements)
* [Installation](#installation)
* [Usage](#usage)
* [Support](#support)
* [Licensing](#licensing)

# Source Code and Documentation
- Source Code: [https://github.com/mindpowered/invoices-csharp](https://github.com/mindpowered/invoices-csharp)
- Documentation: [https://mindpowered.github.io/invoices-csharp](https://mindpowered.github.io/invoices-csharp)

# About
An invoice lists the quantities and costs of the products or services provided by a seller to a buyer. The top of the invoice usually includes the:
- contact information of the seller
- contact information of the buyer
- date of the invoice

In the middle of the invoice is a list of products or services. A line item refers to a line from this list. The line item describes the product or service, quantity, rate, price, and taxes.

At the bottom of the invoice is a summary which usually includes:
- subtotal (before tax)
- total (with tax) amount
- payment terms.

This package aims to provide the tools to create and edit invoices. This is useful for sending by the seller or receiving by the buyer.

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

## MSBuild

Add the following entry to your .csproj file:

```
<PackageReference Include="mindpowered.invoices" Version="0.0.5" />
```


# Usage
```csharp
global::mindpowered.invoices.Invoices inv = new global::mindpowered.invoices.Invoices();
inv.Create("354", "2153", "2021-02-01", "2021-03-01", "Thanks for the business!");
```


# Support
We are here to support using this package. If it doesn't do what you're looking for, isn't working, or you just need help, please [Contact us][contact].

There is also a public [Issue Tracker][bugs] available for this package.

# Licensing
This package is released under the MIT License.



[bugs]: https://github.com/mindpowered/invoices-csharp/issues
[contact]: https://mindpowered.dev/support/?ref=invoices-csharp/
[docs]: https://mindpowered.github.io/invoices-csharp/
[licensing]: https://mindpowered.dev/?ref=invoices-csharp
[purchase]: https://mindpowered.dev/purchase/
