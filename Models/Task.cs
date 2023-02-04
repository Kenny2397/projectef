namespace projectef.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Task 
{
  [Key]
  public Guid TaskId {get; set;}

  [ForeignKey("CategoryId")]
  public Guid CategoryId {get; set;}

  [Required, MinLength(3), MaxLength(50)]
  public string Title {get; set;}
  
  [Required, MinLength(3), MaxLength(250)]
  public string Description {get; set;}
  
  public Priority PriorityTask {get; set;}
  
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public DateTime CreatedAt {get;set;}

  public DateTime UpdatedAt {get; set;}
  public virtual Category Category {get; set;}

  [NotMapped]
  public string Resume {get; set;}
}

public enum Priority 
{
  Baja,
  Media,
  Alta
}