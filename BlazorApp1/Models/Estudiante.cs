using System.Reactive;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("estudiantes")]
public class Estudiante : BaseModel
{
    [Column("nombre")]
    public string? Nombre { get; set; }

    [Column("carrera")]
    public string? Carrera { get; set; }
}