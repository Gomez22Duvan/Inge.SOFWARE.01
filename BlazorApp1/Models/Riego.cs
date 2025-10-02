using System.Reactive;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

public class Riego : BaseModel
{    
    public int Id { get; set; }
    [Column("Fecha")]
    public DateTime Fecha { get; set; }
    [Column("Duracion")]
    public TimeSpan Duracion { get; set; }
    [Column("Estado")]
    public string Estado { get; set; } // "Encendido" o "Apagado"
}