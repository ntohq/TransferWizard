namespace TransferWizard.Abstractions;

public class TransferPlan 
{
   public string IncomingInstitution { get; set; } = string.Empty;
   public string TargetInstitution { get; set; } = string.Empty;
   public List<CourseMap> MappedCourses { get; set; } = new List<CourseMap>();
   public int RemainingCredits { get; set; } 
}
