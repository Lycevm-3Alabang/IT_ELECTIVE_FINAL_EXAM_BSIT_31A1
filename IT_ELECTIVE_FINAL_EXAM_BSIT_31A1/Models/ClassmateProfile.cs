namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models
{
    public enum ProjectStage { Prelim, Midterm, PreFinal, Final }

    public class ClassmateProfile
    {
        public string FullName { get; set; } = "";
        public string Tagline { get; set; } = "";      // e.g. "Aspiring Web Developer"
        public string Course { get; set; } = "";
        public string Section { get; set; } = "";
        public string Bio { get; set; } = "";
        public string PhotoPath { get; set; } = "~/images/default.png";
        public string Email { get; set; } = "";
        public string GitHubUrl { get; set; } = "";
        public string? LinkedInUrl { get; set; }
        public List<string> Skills { get; set; } = new();
        public List<ProjectItem> Projects { get; set; } = new();
    }

    public class ClassmateListItem
    {
        public string Name { get; set; } = "";
        public string ControllerName { get; set; } = "";
    }
}