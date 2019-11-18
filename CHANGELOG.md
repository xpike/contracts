# Change Log

## [1.0.0]

Inital release.

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