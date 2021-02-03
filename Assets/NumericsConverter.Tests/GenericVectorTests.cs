using NUnit.Framework;
using UnityEngine;

namespace NumericsConverter.Tests
{
    public class GenericVectorTests
    {
        [Test]
        public void GenericVectorTestsSimplePasses()
        {
            // Arrange
            var unityVector3 = new Vector3(1f, 2f, 3f);

            // Act
            var systemGenericVector = unityVector3.ToSystemGeneric();

            // Assert
            Assert.AreEqual(unityVector3.x, systemGenericVector[0]);
            Assert.AreEqual(unityVector3.y, systemGenericVector[1]);
            Assert.AreEqual(unityVector3.z, systemGenericVector[2]);
        }
    }
}
