namespace Exercices.Arrays;

using FluentAssertions;
using FluentAssertions.Execution;

public class Tests
{
    [Fact]
    public void Ex1DeclarerUnTableau()
    {
        // ================================ CONSIGNES =================================
        // Déclarer une variable qui contient un tableau de 5 caractères pour former le mot "ARRAY"
        // La variable doit s'appeler 'tableau'.
        // ================================ CONTROLES =================================
        var result = Exercises.Ex1DeclarerUnTableau();
        using var scope = new AssertionScope();
        result.Should().HaveCount(5);
        (new string(result)).Should().Be("ARRAY");
    }

    [Fact]
    public void Ex2MinTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = [12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65];
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.Ex2MinTableau(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(1);
    }

    [Fact]
    public void Ex2MinTableau_TableauVide()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = [];
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.Ex2MinTableau(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(1);
    }

    [Fact]
    public void Ex3MaxTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = new[] { 12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65 };
        Random.Shared.Shuffle(tableau);
        int min = 0;
        // ================================ VOTRE CODE ================================



        // ================================ CONTROLES =================================
        min.Should().Be(1);
    }

    [Fact]
    public void Ex4TrierUnTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = new[] { 12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65 };
        Random.Shared.Shuffle(tableau);
        // ================================ VOTRE CODE ================================



        // ================================ CONTROLES =================================
        tableau.Should().BeInAscendingOrder();
    }
}
