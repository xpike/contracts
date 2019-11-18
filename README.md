# XPike.Contracts

[![Build Status](https://dev.azure.com/xpike/xpike/_apis/build/status/xpike.contracts?branchName=master)](https://dev.azure.com/xpike/xpike/_build/latest?definitionId=10&branchName=master)
![Nuget](https://img.shields.io/nuget/v/XPike.Contracts)

Interfaces for various design-by-contract patterns used in certain xPike libraries:
- DataStores (`XPike.DataStores`)
- Repositories (`XPike.Repositories`)
- Declarative Drivers (`XPike.Drivers.Declarative` / `XPike.Drivers.Http.Declarative`)

Decorative Interfaces:
- `IModel`
  - `IContract`
- `IRecord`
- `IRecordMapper`
 
Functional Interfaces:
- `IMap`
  - `IMapModel`
  - `IMapRecord`

Extension Methods:
- `Enum.GetDescription()`

## Dependencies

None.

## Building and Testing

Building from source and running unit tests requires a Windows machine with:

* .Net Core 3.0 SDK
* .Net Framework 4.6.1 Developer Pack

## Issues

Issues are tracked on [GitHub](https://github.com/xpike/contracts/issues). Anyone is welcome to file a bug,
an enhancement request, or ask a general question. We ask that bug reports include:

1. A detailed description of the problem
2. Steps to reproduce
3. Expected results
4. Actual results
5. Version of the package xPike
6. Version of the .Net runtime

## Contributing

See our [contributing guidelines](https://github.com/xpike/documentation/blob/master/docfx_project/articles/contributing.md)
in our documentation for information on how to contribute to xPike.

## License

xPike is licensed under the [MIT License](LICENSE).
