namespace Exercices;

using FluentAssertions;

public class Arrays
{
    [Fact]
    public void DeclarerUnTableau()
    {
        // ================================ CONSIGNES =================================
        // Déclarer une variable qui contient un tableau de 5 caractères pour former le mot "ARRAY"
        // La variable doit s'appeler 'tableau'.
        // ================================ VOTRE CODE ================================



        // ================================ CONTROLES =================================
        // tableau.Should().HaveCount(5);
        // (new string(tableau)).Should().Be("ARRAY");
    }

    [Fact]
    public void TrierUnTableau()
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
