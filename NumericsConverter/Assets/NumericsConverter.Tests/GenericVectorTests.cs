using NUnit.Framework;
using UnityEngine;

namespace NumericsConverter.Tests
{
    public class GenericVectorTests
    {
        [Test]
        public void CanConvertToGenericF2()
        {
            // Arrange
            var unityVector = new Vector2(1f, 2f);

            // Act
            var systemGenericVector = unityVector.ToSystemGeneric();

            // Assert
            Assert.AreEqual(unityVector.x, systemGenericVector[0]);
            Assert.AreEqual(unityVector.y, systemGenericVector[1]);
        }

        [Test]
        public void CanConvertToGenericF3()
        {
            // Arrange
            var unityVector = new Vector3(1f, 2f, 3f);

            // Act
            var systemGenericVector = unityVector.ToSystemGeneric();

            // Assert
            Assert.AreEqual(unityVector.x, systemGenericVector[0]);
            Assert.AreEqual(unityVector.y, systemGenericVector[1]);
            Assert.AreEqual(unityVector.z, systemGenericVector[2]);
        }

        [Test]
        public void CanConvertToGenericF4()
        {
            // Arrange
            var unityVector = new Vector4(1f, 2f, 3f, 4f);

            // Act
            var systemGenericVector = unityVector.ToSystemGeneric();

            // Assert
            Assert.AreEqual(unityVector.x, systemGenericVector[0]);
            Assert.AreEqual(unityVector.y, systemGenericVector[1]);
            Assert.AreEqual(unityVector.z, systemGenericVector[2]);
            Assert.AreEqual(unityVector.w, systemGenericVector[3]);
        }

        [Test]
        public void CanConvertToGenericI2()
        {
            // Arrange
            var unityVector = new Vector2Int(1, 2);

            // Act
            var systemGenericVector = unityVector.ToSystem();

            // Assert
            Assert.AreEqual(unityVector.x, systemGenericVector[0]);
            Assert.AreEqual(unityVector.y, systemGenericVector[1]);
        }

        [Test]
        public void CanConvertToGenericI3()
        {
            // Arrange
            var unityVector = new Vector3Int(1, 2, 3);

            // Act
            var systemGenericVector = unityVector.ToSystem();

            // Assert
            Assert.AreEqual(unityVector.x, systemGenericVector[0]);
            Assert.AreEqual(unityVector.y, systemGenericVector[1]);
            Assert.AreEqual(unityVector.z, systemGenericVector[2]);
        }
    }
}
