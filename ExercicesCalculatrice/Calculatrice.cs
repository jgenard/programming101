namespace ExercicesCalculatrice;

/// <summary>
/// Calculatrice.
/// </summary>
public class Calculatrice
{
    /// <summary>
    /// Permet à l'utilisateur de saisir quelque chose.
    /// </summary>
    /// <returns>Chaine de caractères représentant la saisie utilisateur.</returns>
    public string Saisir() => Console.ReadLine() ?? string.Empty;

    /// <summary>
    /// Affiche le texte en paramètre dans la console.
    /// </summary>
    /// <param name="texte">Texte à afficher.</param>
    public void Afficher(string texte) => Console.WriteLine(texte);
}
