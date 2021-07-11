using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using MyMath;

public class VectorTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void SumIsImmutable()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1, 1);
        Vector2D vectorB = new Vector2D(2, 2);
        Vector2D result = vectorA.Sum(vectorB);

        Assert.AreEqual(1f, vectorA.x);
        Assert.AreEqual(1f, vectorA.y);
    }

    [Test]
    public void DiffIsImmutable()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1, 1);
        Vector2D vectorB = new Vector2D(2, 2);
        Vector2D result = vectorA.Diff(vectorB);

        Assert.AreEqual(1f, vectorA.x);
        Assert.AreEqual(1f, vectorA.y);
    }

    [Test]
    public void ScaleIsImmutable()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1, 1);
        Vector2D result = vectorA.Scale(10f);

        Assert.AreEqual(1f, vectorA.x);
        Assert.AreEqual(1f, vectorA.y);
    }

    [Test]
    public void NormalizeIsMutable()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1f, 1f);
        vectorA.Normalize();

        Assert.AreEqual(0.7071f, vectorA.x, 0.01);
        Assert.AreEqual(0.7071f, vectorA.y, 0.01);
    }

    [Test]
    public void NormalizedIsImmutable()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1f, 1f);
        vectorA.Normalized();

        Assert.AreEqual(1f, vectorA.x);
        Assert.AreEqual(1f, vectorA.y);
    }

    [Test]
    public void SumWorksCorrectly()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1, 1);
        Vector2D vectorB = new Vector2D(2, 2);
        Vector2D result = vectorA.Sum(vectorB);

        Assert.AreEqual(3f, result.x);
        Assert.AreEqual(3f, result.y);
    }

    [Test]
    public void DiffWorksCorrectly()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1, 1);
        Vector2D vectorB = new Vector2D(2, 2);
        Vector2D result = vectorA.Diff(vectorB);

        Assert.AreEqual(-1f, result.x);
        Assert.AreEqual(-1f, result.y);
    }

    [Test]
    public void ScaleWorksCorrectly()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1, 1);
        Vector2D result = vectorA.Scale(10f);

        Assert.AreEqual(10f, result.x);
        Assert.AreEqual(10f, result.y);
    }

    [Test]
    public void NormalizedWorksCorrectly()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1f, 1f);
        Vector2D result = vectorA.Normalized();

        Assert.AreEqual(0.7071f, result.x, 0.01f);
        Assert.AreEqual(0.7071f, result.y, 0.01f);
    }

    [Test]
    public void DotProductWorksCorrectly()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(0f, 1f);
        Vector2D vectorB = new Vector2D(1f, 0f);
        float result = vectorA.Dot(vectorB);

        // Perpendicular vectors have a dot product of 0.
        Assert.AreEqual(0f, result);
    }

    [Test]
    public void VectorByFloatPerformScale()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(1f, 1f);
        Vector2D result = vectorA * 10f;

        Assert.AreEqual(10f, result.x);
        Assert.AreEqual(10f, result.y);
    }

    [Test]
    public void VectorByVectorPerformDotProduct()
    {
        // Use the Assert class to test conditions
        Vector2D vectorA = new Vector2D(0f, 1f);
        Vector2D vectorB = new Vector2D(1f, 0f);
        float result = vectorA * vectorB;

        // Perpendicular vectors have a dot product of 0.
        Assert.AreEqual(0f, result);
    }
}
