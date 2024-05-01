namespace Exercices;

using FluentAssertions;

public class Variables
{
    [Fact]
    public void InversionDeVariables()
    {
        // ================================ CONSIGNES =================================
        // Inverser les valeurs de a et b.
        int a = 5;
        int b = 2;
        // ================================ VOTRE CODE ================================



        // ================================ CONTROLES =================================
        a.Should().Be(2);
        b.Should().Be(5);
    }
}
