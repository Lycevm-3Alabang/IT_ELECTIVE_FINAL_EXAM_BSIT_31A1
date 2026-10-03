using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Manzano, Justin")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class ManzanoJustinController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Manzano, Justin",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "3A",
                Bio = "to see is to believe",
                PhotoPath = "~/images/juandelacruz.jpg",
                Email = "manzanojustin37@gmail.com",
                GitHubUrl = "https://github.com/justin3435-324234",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "Java", "HTML/CSS" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim H1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/justin3435-324234/BSIT31E1_PRELIM_H1_MANZANO_JUSTIN.git",
                        Description = "Prelim Project",
                        TechStack = new List<string> { "C#" }
                    },


                    new ProjectItem
                    {
                        Title = "Prelim A2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/justin3435-324234/BSIT31E1_PRELIM_A2_MANZANO_JUSTIN.git",
                        Description = "Prelim Project",
                        TechStack = new List<string> { "C#" }
                    },


                    new ProjectItem
                    {
                        Title = "Midterm A1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/justin3435-324234/IT_ELECTIVE_2_Midterm_A1_Manzano_Justin.git",
                        Description = "Midterm project",
                        TechStack = new List<string> { "C#" }
                   
             
                    }
                }
            };

            return View(profile);
        }
    }
}