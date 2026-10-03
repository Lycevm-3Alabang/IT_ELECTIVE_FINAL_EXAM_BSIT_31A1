namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models
{

        public class ProjectItem
        {
            public string Title { get; set; } = "";
            public ProjectStage Stage { get; set; }
            public string RepoUrl { get; set; } = "";
            public string? LiveUrl { get; set; }          // optional: deployed demo
            public string Description { get; set; } = "";
            public List<string> TechStack { get; set; } = new();
        }

}
