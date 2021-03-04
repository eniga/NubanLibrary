# NubanLibrary
[![NuGet]](https://www.nuget.org/packages/NubanLibrary)
[![License MIT](https://img.shields.io/badge/license-MIT-green.svg)](https://opensource.org/licenses/MIT)
A library for nuban functions build with ASP.NET 5. 

This gives you access to functions such as Validate a Nuban number and generate a new nuban number

## Installation

```
 dotnet add package NubanLibrary
```

## Contributors

* [Eniga Ahiante](https://github.com/eniga)

## Contribute

Contributions to the package are always welcome!


* Report any bugs or issues you find on the [issue tracker](https://github.com/eniga/NubanLibrary/issues).
* You can grab the source code at the package's [git repository](https://github.com/eniga/NubanLibrary).

## How to use

Import the library as 

```
using NubanLibrary;
```

Call methods as below

## ValidateNubanAccount
```
Nuban.ValidateNubanAccount(AccountNumber, BankCode);
```

## GenerateNubanAccount
```
Nuban.GenerateNubanAccount(serial, bankcode);
```

## License

All contents of this package are licensed under the [MIT license](https://opensource.org/licenses/MIT).
