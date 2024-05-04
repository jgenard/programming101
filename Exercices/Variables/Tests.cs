namespace Exercices.Variables;

using FluentAssertions;
using FluentAssertions.Execution;

public class Tests
{
    [Fact]
    public void InversionDeVariablesBase()
    {
        // ================================ CONSIGNES =================================
        // Inverser les valeurs de a et b.
        int A = 2;
        int B = 5;
        // ================================ VOTRE CODE ================================

        var (a, b) = Exercises.InversionDeVariables(A, B);

        // ================================ CONTROLES =================================
        using var scope = new AssertionScope();
        a.Should().Be(B);
        b.Should().Be(A);
    }

    [Fact]
    public void InversionDeVariablesNegatifs()
    {
        // ================================ CONSIGNES =================================
        // Inverser les valeurs de a et b.
        int A = -10;
        int B = -8;
        // ================================ VOTRE CODE ================================

        var (a, b) = Exercises.InversionDeVariables(A, B);

        // ================================ CONTROLES =================================
        using var scope = new AssertionScope();
        a.Should().Be(B);
        b.Should().Be(A);
    }
}
