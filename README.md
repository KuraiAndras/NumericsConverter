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
