using UVector2 = UnityEngine.Vector2;
using SVector2 = System.Numerics.Vector2;
using UVector3 = UnityEngine.Vector3;
using SVector3 = System.Numerics.Vector3;
using UVector4 = UnityEngine.Vector4;
using SVector4 = System.Numerics.Vector4;

namespace NumericsConverter
{
    public static class VectorConverter
    {
        public static SVector2 ToSystem(this UVector2 vector) => new SVector2(vector.x, vector.y);
        public static UVector2 ToUnity(this SVector2 vector) => new UVector2(vector.X, vector.Y);
        public static SVector3 ToSystem(this UVector3 vector) => new SVector3(vector.x, vector.y, vector.z);
        public static UVector3 ToUnity(this SVector3 vector) => new UVector3(vector.X, vector.Y, vector.Z);
        public static SVector4 ToSystem(this UVector4 vector) => new SVector4(vector.x, vector.y, vector.z, vector.w);
        public static UVector4 ToUnity(this SVector4 vector) => new UVector4(vector.X, vector.Y, vector.Z, vector.W);
    }
}
