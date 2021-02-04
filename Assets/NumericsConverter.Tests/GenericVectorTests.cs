using NUnit.Framework;
using UnityEngine;

namespace NumericsConverter.Tests
{
    public class GenericVectorTests
    {
        [Test]
        public void CanConvertToGeneric2()
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
        public void CanConvertToGeneric3()
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
        public void CanConvertToGeneric4()
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
    }
}
