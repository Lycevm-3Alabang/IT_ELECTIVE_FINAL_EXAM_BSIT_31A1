using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Mendoza, Stephanie")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class StephanieMendozaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Stephanie Mendoza",
                Tagline = "Aspiring UI Designer",
                Course = "BS Information Technology",
                Section = "3A",
                Bio = "I’m an aspiring UI Designer. I loves creating digital products that look great and feel smooth to use.",
                PhotoPath = "~/images/stephaniemendoza.jpg",
                Email = "tepteptep231@email.com",
                GitHubUrl = "https://github.com/stephanie-mendoza189",
                LinkedInUrl = "",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },



                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "BSIT31E1_PRELIM_H1_MENDOZA_STEPHANIE",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/BSIT31E1_PRELIM_H1_MENDOZA_STEPHANIE.git",
                        Description = "Menu-driven interface to track student grades, compute averages and identify top performers.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT31E1_Prelim_A1_Mendoza_Stephanie",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/BSIT31E1_Prelim_A1_Mendoza_Stephanie.git",
                        Description = "FizzBuzz console application.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT31E1_Prelim_A2_Mendoza_Stephanie",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/BSIT31E1_Prelim_A2_Mendoza_Stephanie.git",
                        Description = "C# console calculator.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT31E1_PRELIM_H2_Mendoza_Stephanie",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/BSIT31E1_PRELIM_H2_Mendoza_Stephanie.git",
                        Description = "Implement XML, JSON and CSV file reader classes.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT_31E1_PRELIM_Q1_Mendoza_Stephanie",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/BSIT_31E1_PRELIM_Q1_Mendoza_Stephanie.git",
                        Description = "Object-oriented programming coding challenge focusing on inheritance, interfaces and vehicle design.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT31E1_Prelim_A3_Mendoza_Stephanie",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/BSIT31E1_Prelim_A3_Mendoza_Stephanie.git",
                        Description = "C# console application that demonstrates API communication.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_PRELIM_EXAM_MENDOZA_STEPHANIE",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_PRELIM_EXAM_MENDOZA_STEPHANIE.git",
                        Description = "C# prelim exam consisting of two projects.",
                        TechStack = new List<string> { "C#", "Console" }
                    },







                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_Midterm_A1_Mendoza_Stephanie",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_Midterm_A1_Mendoza_Stephanie.git",
                        Description = "Part2 of A1 - Develop a responsive personal portfolio.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_Midterm_A1_Mendoza_Stephanie (PART2 - BRANCH)",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_Midterm_A1_Mendoza_Stephanie/tree/IT_ELECTIVE_2_MIDTERM_A2_MENDOZA_STEPHANIE",
                        Description = "Personal portfolio website using ASP.NET Core MVC.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_Q1_BEMR",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_MIDTERM_Q1_BEMR.git",
                        Description = "A collaboration code consist of 4 members. (Hackathon).",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_BSIT_31E1_MENDOZA_STEPHANIE",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_BSIT_31E1_MENDOZA_STEPHANIE.git",
                        Description = "ASP.NET Core MVC login page demonstrating model binding, data annotations and server-side.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_Q2_MENDOZA_STEPHANIE",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_MIDTERM_Q2_MENDOZA_STEPHANIE_.git",
                        Description = "Authenticated ASP.NET Core MVC playlist builder.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_Q3_Mendoza_Stephanie",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_MIDTERM_Q3_Mendoza_Stephanie.git",
                        Description = "Cookie-based authentication, authorization attributes, and ViewModels.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_EXAM_3_MENDOZA_STEPHANIE",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_MIDTERM_EXAM_3_MENDOZA_STEPHANIE.git",
                        Description = "ASP.NET Core MVC Visitor Pass Monitoring System.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Mendoza_Stephanie",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Mendoza_Stephanie.git",
                        Description = "Point of Sale (POS) web application using ASP.NET Core MVC.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },






                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_PREFINALS_PROJECT",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_PREFINALS_PROJECT.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "A group project consist of 3 members.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Mendoza_Stephanie",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Mendoza_Stephanie.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "Present exam questions and answers.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    }
                }
            };

            return View(profile);
        }
    }
}
