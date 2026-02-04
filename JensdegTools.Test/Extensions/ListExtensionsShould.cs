using AwesomeAssertions;
using JensdegTools.Extensions;

namespace JensdegTools.Test.Extensions;

public class ListExtensionsShould
{
    private class A;
    private class B : A;
    private class C : A;
    private interface IA;
    private class IB : IA;
    private class IC : IA;

    [Fact]
    public void ReturnTrueWhenListsContainsSameType()
    {
        // Arrange
        List<A> InheritenceList = [new A(), new B(), new C()];
        List<IA> interfaceList = [new IB(), new IC()];

        // Act & Assert
        InheritenceList.ContainsType(typeof(A)).Should().BeTrue();
        InheritenceList.ContainsType(typeof(C)).Should().BeTrue();
        InheritenceList.ContainsType(typeof(B)).Should().BeTrue();


        interfaceList.ContainsType(typeof(IB)).Should().BeTrue();
        interfaceList.ContainsType(typeof(IC)).Should().BeTrue();
    }

    [Fact]
    public void ReturnFalseWhenListsContainsSameType()
    {
        // Arrange
        List<A> InheritenceList = [new B()];
        List<IA> interfaceList = [new IB()];

        // Act & Assert
        InheritenceList.ContainsType(typeof(A)).Should().BeFalse();
        InheritenceList.ContainsType(typeof(C)).Should().BeFalse();


        interfaceList.ContainsType(typeof(IC)).Should().BeFalse();
    }

}
