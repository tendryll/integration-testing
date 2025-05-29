using System.ComponentModel.DataAnnotations.Schema;

[Table("todos")]
public class Todo
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string? Name { get; set; }
    
    [Column("is_complete")]
    public bool IsComplete { get; set; }
}