using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Ocampo,Kylie")]
    public class OcampoKylieController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Kylie Lizzette Ann M.Ocampo",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31A1",
                Bio = "I am an aspiring full-stack developer interested in creating practical and user-friendly applications. I enjoy learning different programming technologies and developing projects that improve my problem-solving and technical skills. My goal is to become a skilled full-stack developer and build reliable software solutions.",
                PhotoPath = "~/images/juandelacruz.jpg",
                Email = "kykie1008@gmail.com",
                GitHubUrl = "https://github.com/kykie-hub",
                LinkedInUrl = "https://linkedin.com/in/your-profile",
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/kykie-hub/-IT_ELECTIVE_2_PRELIM_EXAM_OCAMPO_KYLIE-LIZZETTE-ANN-.git",
                        Description = "A C# console-based application developed as part of the Prelim Examination. It demonstrates fundamental programming concepts such as variables, input and output, conditional statements, and basic program logic.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/kykie-hub/IT_ELECTIVE_2_OCAMPO_KYLIE_BSIT31E1.git",
                        Description = "A C# Windows Forms application developed for the Midterm Examination. It demonstrates the use of graphical user interfaces, event-driven programming, form controls, and basic application functionality.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "PreFinal and Final Exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/kykie-hub/IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Ocampo_Kylie.git",
                        LiveUrl = null,
                        Description = "An ASP.NET Core MVC web application developed as part of the Pre-Final and Final Examination. It demonstrates MVC architecture, database integration using SQL Server, CRUD operations, and the development of a functional web-based system.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}