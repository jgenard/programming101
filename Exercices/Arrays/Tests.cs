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
    public void Ex2MinTableau_TresGrandTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        var tableau = BuildArray(10000);
        // ================================ CONTROLES =================================
        var result = Exercises.Ex2MinTableau(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Min());
    }

    [Fact]
    public void Ex2MinTableau_TableauVide()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = [];
        // ================================ CONTROLES =================================
        var result = Exercises.Ex2MinTableau(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Min());
    }

    [Fact]
    public void Ex3MaxTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = new[] { 12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65 };
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.Ex3MaxTableau(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Max());
    }

    [Fact]
    public void Ex3MaxTableau_TresGrandTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        var tableau = BuildArray(10000);
        // ================================ CONTROLES =================================
        var result = Exercises.Ex3MaxTableau(tableau);
        using var scope = new AssertionScope();
        result.Should().Be(tableau.Max());
    }

    [Fact]
    public void Ex4TrierUnTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        int[] tableau = new[] { 12, 980, 45, 32, 15, 65, 84, 656, 1, 21, 2, 3, 4, 10, 65 };
        Random.Shared.Shuffle(tableau);
        // ================================ CONTROLES =================================
        var result = Exercises.Ex4TrierTableau(tableau);
        using var scope = new AssertionScope();
        tableau.Should().BeInAscendingOrder();
    }

    [Fact]
    public void Ex4TrierUnTableau_TresGrandTableau()
    {
        // ================================ CONSIGNES =================================
        // Sans utiliser LINQ, trier le tableau du plus petit au plus grand nombre.
        var tableau = BuildArray(10000);
        // ================================ CONTROLES =================================
        var result = Exercises.Ex4TrierTableau(tableau);
        using var scope = new AssertionScope();
        tableau.Should().BeInAscendingOrder();
    }

    private static int[] BuildArray(int taille)
    {
        int[] tableau = new int[taille];
        for (int i = 0; i < taille; i++)
        {
            tableau[i] = Random.Shared.Next();
        }
        Random.Shared.Shuffle(tableau);
        return tableau;
    }
}
