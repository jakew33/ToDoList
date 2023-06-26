using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models;

public class Todo
{
  public Todo( int id, string name, string description, bool? completed)
  {
    Id = id;
    Name = name;
    Description = description;
    Completed = completed;
  }

  public int Id { get; set; }
  [Required]
  public string Name { get; set; }
  public string Description { get; set; }
  public bool? Completed { get; set; }
}