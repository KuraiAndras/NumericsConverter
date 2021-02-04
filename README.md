# NumericsConverter [![openupm](https://img.shields.io/npm/v/com.kuraiandras.numericsconverter?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.kuraiandras.numericsconverter/)

Conversion methods between Unity vectory types and System.Numerics.Vector as extension methods

## Getting Started

The recommended way of installation is through open upm.

```pwsh
openupm add com.kuraiandras.linkergenerator
```

```csharp
using NumericsConverter; // use this namespace for the exentsion methods
```

Special thanks for [TheZombieKiller](https://forum.unity.com/members/thezombiekiller.195610/) from the [unity forum](https://forum.unity.com/threads/system-numerics.451073/) for the help with removing unnecessary allocations.

## Available conversions

| From                       | To                         |
|----------------------------|----------------------------|
| UnityEngine.Vector2        | System.Numerics.Vector2    |
| UnityEngine.Vector2        | System.Numerics.Vector     |
| System.Numerics.Vector2    | UnityEngine.Vector2        |
| UnityEngine.Vector3        | System.Numerics.Vector3    |
| UnityEngine.Vector3        | System.Numerics.Vector     |
| System.Numerics.Vector3    | UnityEngine.Vector3        |
| UnityEngine.Vector4        | System.Numerics.Vector4    |
| UnityEngine.Vector4        | System.Numerics.Vector     |
| System.Numerics.Vector4    | UnityEngine.Vector4        |
| UnityEngine.Vector2Int     | System.Numerics.Vecto      |
| System.Numerics.Vector     | UnityEngine.Vector2Int     |
| UnityEngine.Vector3Int     | System.Numerics.Vector     |
| System.Numerics.Vector     | UnityEngine.Vector3Int     |
| UnityEngine.Quaternion     | System.Numerics.Quaternion |
| System.Numerics.Quaternion | UnityEngine.Quaternion     |
| UnityEngine.Plane          | System.Numerics.Plane      |
| System.Numerics.Plane      | UnityEngine.Plane          |
| UnityEngine.Matrix4x4      | System.Numerics.Matrix4x4  |
| System.Numerics.Matrix4x4  | UnityEngine.Matrix4x4      |

## Allocation benchmarks

Doing 100000 conversions from UnityEngine.Vector4 to System.Numerics.Vector

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 5 1600X, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4300.0), X64 RyuJIT
  .NET 4.7.2 : .NET Framework 4.8 (4.8.4300.0), X64 RyuJIT

Job=.NET 4.7.2  Runtime=.NET 4.7.2  

```
|  Method |     Mean |     Error |    StdDev |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------- |---------:|----------:|----------:|----------:|------:|------:|----------:|
|   Alloc | 2.276 ms | 0.0012 ms | 0.0011 ms | 5839.8438 |     - |     - | 5616878 B |
| NoAlloc | 1.503 ms | 0.0266 ms | 0.0249 ms |         - |     - |     - |         - |

