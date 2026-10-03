using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Barcinas, Marc Denize")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class BarcinasMarcDenizeController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Barcins, Marc Denize",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "BSIT31E1",
                Bio = "Beginner Programmer that is willing to learn anything about programming.",
                PhotoPath = "~/images/juandelacruz.jpg",
                Email = "Barcinasoct@gmail.com",
                GitHubUrl = "https://github.com/MarcBarcinas",
                LinkedInUrl = "",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MarcBarcinas/BSIT_31E1_PRELIM_Q1_Barcinas_MarcDenize",
                        Description = "Prelim Quiz",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                     new ProjectItem
                    {
                        Title = "Prelim H1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/BSIT31E1_PRELIM_H1_MENDOZA_STEPHANIE",
                        Description = "Prelim H1",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                     new ProjectItem
                    {
                        Title = "Prelim H2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MarcBarcinas/BSIT31E1_PRELIM_H2_Barcinas_MarcDenize",
                        Description = "Prelim H2",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                      new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MarcBarcinas/IT_ELECTIVE_2_PRELIM_EXAM_BARCINAS_MARC",
                        Description = "Prelim Exam",
                        TechStack = new List<string> { "C#", "Console" }
                    },


                    new ProjectItem
                    {
                        Title = "Midterem Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/MarcBarcinas/IT_ELECTIVE_2_MIDTERM_Q2_BARCINAS_MARCDENIZE",
                        Description = "Midterm Quiz 2",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                     new ProjectItem
                    {
                        Title = "Pre-Finals Activity 1",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/MarcBarcinas/MarcBarcinas-BSIT31E1_PREFINALS_A1_BARCINAS_MARC",
                        Description = "Pre-Finals Activity 1",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                      new ProjectItem
                    {
                        Title = "Pre-Finals Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/MarcBarcinas/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_BARCINAS_MARCDENIZE",
                        Description = "Pre-Finals Exam",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "Final Project Title",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/your-username/final-repo",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}