using OperationOOP.Core.Interfaces;

namespace OperationOOP.Core.Models;
public class Bonsai : Plant , ILovePruning
{
                
    public BonsaiStyle Style { get; set; }
    public DateTime LastPruned {  get; set; }

    public void Prune()
    {
        Console.WriteLine($"Senast beskuren: {LastPruned}");
        LastPruned = DateTime.Now;
        Console.WriteLine($"Den har nu blivit beskuren: {LastPruned}");
    }
}

public enum BonsaiStyle
{
    Chokkan,    // Formal Upright
    Moyogi,     // Informal Upright
    Shakan,     // Slanting
    Kengai,     // Cascade
    HanKengai   // Semi-cascade
}




