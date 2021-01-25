using System.Numerics;
using SVector2 = System.Numerics.Vector2;
using SVector3 = System.Numerics.Vector3;
using SVector4 = System.Numerics.Vector4;
using UVector2 = UnityEngine.Vector2;
using UVector2Int = UnityEngine.Vector2Int;
using UVector3 = UnityEngine.Vector3;
using UVector3Int = UnityEngine.Vector3Int;
using UVector4 = UnityEngine.Vector4;

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
        public static SVector ToSystem(this UVector2Int vector) => new SVector(new[] { vector.x, vector.y });
        public static UVector2Int ToUnity2(this SVector vector) => new UVector2Int(vector[0], vector[1]);
        public static SVector ToSystem(this UVector3Int vector) => new SVector(new[] { vector.x, vector.y, vector.z });
        public static UVector3Int ToUnity3(this SVector vector) => new UVector3Int(vector[0], vector[1], vector[2]);
        public static SMatrix4x4 ToSystem(this UMatrix4x4 matrix) => new SMatrix4x4(
            matrix.m00, matrix.m01, matrix.m02, matrix.m03,
            matrix.m10, matrix.m11, matrix.m12, matrix.m13,
            matrix.m20, matrix.m21, matrix.m22, matrix.m23,
            matrix.m30, matrix.m31, matrix.m32, matrix.m33);

        public static UMatrix4x4 ToUnity(this SMatrix4x4 matrix) => new UMatrix4x4
        {
            m00 = matrix.M11,
            m01 = matrix.M12,
            m02 = matrix.M13,
            m03 = matrix.M14,
            m10 = matrix.M21,
            m11 = matrix.M22,
            m12 = matrix.M23,
            m13 = matrix.M24,
            m20 = matrix.M31,
            m21 = matrix.M32,
            m22 = matrix.M33,
            m23 = matrix.M34,
            m30 = matrix.M41,
            m31 = matrix.M42,
            m32 = matrix.M43,
            m33 = matrix.M44,
        };

        public static SQuaternion ToSystem(this UQuaternion quaternion) => new SQuaternion(quaternion.x, quaternion.y, quaternion.z, quaternion.w);
        public static UQuaternion ToUnity(this SQuaternion quaternion) => new UQuaternion(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        public static SPlane ToSystem(this UPlane plane) => new SPlane(plane.normal.ToSystem(), plane.distance);
        public static UPlane ToUnity(this SPlane plane) => new UPlane(plane.Normal.ToUnity(), plane.D);
    }
}
