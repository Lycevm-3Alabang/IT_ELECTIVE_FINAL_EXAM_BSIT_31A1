using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Arejola, Jerome A.")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class ArejolaJeromeController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Jerome A. Arejola",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "3A",
                Bio = "I'm really into tech and problem-solving, especially when it comes to figuring out how code can make everyday life a little easier. " +
                "I love building practical apps and fun little websites that take a messy idea and turn it into something cool and easy to use. " +
                "My big goal for college is to keep leveling up my coding skills, work on awesome projects with friends, and get ready for a career where I never stop building..",
                PhotoPath = "Views/images/Image.png",
                Email = "jeromearejola30@gmail.com",
                GitHubUrl = "https://github.com/jeromearejola-30",
                LinkedInUrl = " ",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "BSIT31E1_PRELIM_H1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/jeromearejola-30/BSIT31E1_PRELIM_H1_AREJOLA_JEROME.git",
                        Description = "A student management system where you add compute grades for the students.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/jeromearejola-30/IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                        Description = " A point of sale web application designed for cashiers to build shopping carts, manage inventory, process customer sales, " +
                        "and review completed transaction history.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                     new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_31E1_PREFINAL_EXAM",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/jeromearejola-30/IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Arejola_Jerome.git",
                        Description = "This project is an ASP.NET Core MVC application developed as part of the Prefinal Examination for IT Elective 2 (Web System and Technologies)." +
                        " It presents a dynamic interactive dashboard containing 20 prefinal examination questions, multiple-choice options, correct answers, and explanations.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    
                }
            };

            return View(profile);
        }
    }
}