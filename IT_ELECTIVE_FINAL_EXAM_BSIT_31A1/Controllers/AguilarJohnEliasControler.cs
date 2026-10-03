using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Aguilar, John Elias")]
    public class JohnEliasAguilarController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "John Elias Aguilar",
                Tagline = "Aspiring Web and Software Developer",
                Course = "BS Information Technology",
                Section = "3E1",

                Bio = "I am a BS Information Technology student interested in web development, software development, and modern technologies. I enjoy creating applications and improving my programming skills through different academic projects. My goal is to become a skilled IT professional and software developer.",

                PhotoPath = "~/images/johneliasaguilar.jpg",

                Email = "your-email@example.com",

                GitHubUrl = "https://github.com/jeaguilar547-ui",
                LinkedInUrl = null,

                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET Core MVC",
                    "HTML/CSS",
                    "JavaScript",
                    "SQL",
                    "GitHub"
                },

                // Keep projects in Prelim → Midterm → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Project",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/jeaguilar547-ui/IT_ELECTIVE_2_TEMPLATE.git",
                        Description = "An IT Elective 2 project template used as a foundation for developing an ASP.NET Core MVC application.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML/CSS"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/jeaguilar547-ui/IT_ELECTIVE_2_MIDTERM_EXAM_-set-5-_-Aguilar-John-Elias-.git",
                        Description = "A midterm examination project developed as part of the IT Elective 2 course.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML/CSS"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Pre-Final Exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/jeaguilar547-ui/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Aguilar_JohnElias.git",
                        LiveUrl = null,
                        Description = "An ASP.NET Core MVC project developed for the IT Elective 2 pre-final examination.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML/CSS"
                        }
                    }
                }
            };

            return View(profile);
        }
    }
}