using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class NavigationSystemTests
{
    private NavigationSystem navigationSystem;
    private GameObject mockTarget;

    [SetUp]
    public void Setup()
    {
        // Create a new instance of NavigationSystem for each test
        navigationSystem = new GameObject().AddComponent<NavigationSystem>();

        // Create a mock target object
        mockTarget = new GameObject("MockTarget");
        navigationSystem.SetTarget(mockTarget);
    }

    [TearDown]
    public void Teardown()
    {
        // Clean up the test objects
        Object.DestroyImmediate(navigationSystem.gameObject);
        Object.DestroyImmediate(mockTarget);
    }

    [Test]
    public void HandleTargetChanging_TargetChanged_TargetIsNotNull()
    {
        // Arrange
        Vector3 originalTargetPosition = navigationSystem.GetTargetPosition();

        // Act
        navigationSystem.HandleTargetChanging();

        // Assert
        Assert.IsNotNull(navigationSystem.GetTarget());
        Assert.AreNotEqual(originalTargetPosition, navigationSystem.GetTargetPosition());
    }

    [Test]
    public void CorrectionAngleOnY_TargetAt45Degrees_Returns45()
    {
        // Arrange
        mockTarget.transform.position = new Vector3(1f, 0f, 1f);
        navigationSystem.transform.rotation = Quaternion.Euler(0f, 45f, 0f);

        // Act
        float angle = navigationSystem.CorrectionAngleOnY();

        // Assert
        Assert.AreEqual(45f, angle);
    }

    [Test]
    public void CorrectionAngleOnX_TargetAt45Degrees_Returns0()
    {
        // Arrange
        mockTarget.transform.position = new Vector3(0f, 1f, 1f);
        navigationSystem.transform.rotation = Quaternion.Euler(0f, 0f, 45f);

        // Act
        float angle = navigationSystem.CorrectionAngleOnX();

        // Assert
        Assert.AreEqual(0f, angle);
    }
}