using ExercicesConsole;

const string br = "===============================================";

var exercices = new Dictionary<int, Action>
{
    { 1, ChessExercices.CouleurCaseEchiquier },
    { 2, ChessExercices.DeplacementTour },
    { 3, ChessExercices.DeplacementFou },
    { 4, ChessExercices.DeplacementCavalier },
};

int numeroExercice;
do
{
    numeroExercice = ChoixExercices();
    if (exercices.TryGetValue(numeroExercice, out var action))
    {
        Console.Clear();
        Console.WriteLine(br);
        Console.WriteLine($"Début de l'exercice {action.Method.Name}");
        Console.WriteLine(br);
        action();
        Console.WriteLine(br);
        Console.WriteLine($"Fin de l'exercice {action.Method.Name}");
        Console.WriteLine(br);
        Console.WriteLine();
        Console.WriteLine("Appuyer sur une touche pour continuer...");
        Console.ReadKey();
    }
    else if (numeroExercice != 0)
    {
        Console.WriteLine("Exercice inconnu, veuillez recommencer.");
        Console.WriteLine();
        Console.WriteLine("Appuyer sur une touche pour continuer...");
        Console.ReadKey();
    }
} while (numeroExercice != 0);

int ChoixExercices()
{
    int? exerciceChoisi = null;
    do
    {
        Console.Clear();
        Console.WriteLine(br);
        Console.WriteLine("Exercices :");

        foreach (var exercice in exercices)
        {
            Console.WriteLine($"{exercice.Key} - {exercice.Value.Method.Name}");
        }

        Console.WriteLine(br);
        Console.WriteLine("Saisir le numéro de l'exercice à exécuter (0 pour quitter) : ");
        if (int.TryParse(Console.ReadLine(), out var input))
        {
            exerciceChoisi = input;
        }
        else
        {
            Console.WriteLine("Saisie incorrecte, veuillez recommencer.");
            Console.WriteLine();
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
        }
    } while (!exerciceChoisi.HasValue);

    return exerciceChoisi.GetValueOrDefault();
}
