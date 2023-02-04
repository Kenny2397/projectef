namespace projectef.Models;

using System.ComponentModel.DataAnnotations;
public class Category
{
  [Key]
  public Guid CategoryId {get; set;}
  [Required]
  [MaxLength(150)]
  public string Name {get; set;}
  [Required]
  public string Description {get; set;}
  public virtual ICollection<Task> Tasks {get; set;}
}