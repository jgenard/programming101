namespace CoursTests;

public class Tests
{
    [Fact]
    public void Test1()
    {

    }
}

public class FactureService
{
    private readonly IFactureRepository factureRepository;
    private readonly IClientRepository clientRepository;

    public FactureService(IFactureRepository factureRepository, IClientRepository clientRepository)
    {
        this.factureRepository = factureRepository;
        this.clientRepository = clientRepository;
    }

    public Facture GenererFacture(int clientId)
    {
        var lignes = factureRepository.GetLignesEnAttente(clientId);
        var remises = clientRepository.GetRemiseClient(clientId);

        // Calcul de la facture
        var totalSansRemise = lignes.Sum(l => l.PrixHT * l.Volume * (1 + l.TVA));

        // RDG : Le pourcentage de remise est limité à 50%.
        var pourcentageRemise = Math.Min(remises.Sum(r => r.Pourcentage), 0.50m);

        return new Facture
        {
            Total = totalSansRemise - (totalSansRemise * pourcentageRemise)
        };
    }
}

public class Facture
{
    public List<LigneFacture> LigneFactures { get; set; } = new List<LigneFacture>();
    public decimal Total { get; set; }
}

public interface IClientRepository
{
    List<Remise> GetRemiseClient(int clientId);
}

public interface IFactureRepository
{
    List<LigneFacture> GetLignesEnAttente(int clientId);
}

public class Remise
{
    /// <summary>
    /// Exprimé sous la forme 0.10 pour 10%.
    /// </summary>
    public decimal Pourcentage { get; set; }
}

public class LigneFacture
{
    public decimal PrixHT { get; set; }

    /// <summary>
    /// Exprimé sous la forme 0.10 pour 10%.
    /// </summary>
    public decimal TVA { get; set; }
    public decimal Volume { get; set; }
}
