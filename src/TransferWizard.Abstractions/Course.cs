namespace TransferWizard.Abstractions;

public class Course
{
   public string Name { get; set; } = string.Empty;
   public string? Subject { get; set; } = null;
   public int Credits { get; set; }
   public DateOnly Year { get; set; } 
   public CourseTerm Term { get; set; }
   public bool IsCompleted { get; set; } = false;
}
