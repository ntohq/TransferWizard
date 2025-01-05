namespace TransferWizard.Abstractions;

public class AcademicPlan
{
   public List<Course> Courses { get; set; } = new List<Course>();
   public AcademicInstitution Institution { get; set; } = new();
   public int UncompletedCount => Courses.Select(c => !c.IsCompleted).Count();
   public int CompletedCount => Courses.Select(c => c.IsCompleted).Count();
}
