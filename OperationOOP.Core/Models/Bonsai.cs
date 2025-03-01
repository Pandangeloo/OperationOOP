using OperationOOP.Core.Interfaces;

namespace OperationOOP.Core.Models;
public class Bonsai : Plant , ILovePruning
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int AgeYears { get; set; }    
    public DateTime LastWatered { get; set; }
    public CareLevel CareLevel { get; set; }

    
    public DateTime LastPruned { get; set; }            
    public BonsaiStyle Style { get; set; }
    
}

public enum BonsaiStyle
{
    Chokkan,    // Formal Upright
    Moyogi,     // Informal Upright
    Shakan,     // Slanting
    Kengai,     // Cascade
    HanKengai   // Semi-cascade
}




