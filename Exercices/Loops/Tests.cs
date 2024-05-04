namespace Exercices.Loops;

using FluentAssertions;
using FluentAssertions.Execution;

public class Tests
{
    [Fact]
    public void SommeAvecFor()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = [12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65];
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.SommeAvecFor(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Sum());
    }

    [Fact]
    public void SommeAvecWhile()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = [12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65];
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.SommeAvecWhile(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Sum());
    }

    [Fact]
    public void SommeAvecDoWhile()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = [12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65];
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.SommeAvecDoWhile(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Sum());
    }

    [Fact]
    public void SommeAvecForEach()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = [12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65];
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.SommeAvecForEach(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Sum());
    }
}
