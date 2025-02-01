using Shouldly;

namespace FirstMapper.Tests;

public class UnitTest
{
    [Fact]
    public void TestXUnitIsWorking()
    {
        // Arrange
        const bool truthy = true;

        // Assert
        Assert.True(truthy);
    }

    [Fact]
    public void TestShudlyIsWorking()
    {
        // Arrange
        const bool truthy = true;

        // ReSharper disable once ConditionIsAlwaysTrueOrFalse
        // Assert
        truthy.ShouldBe(true, "There is a problem with Shouldly.");
    }
}
