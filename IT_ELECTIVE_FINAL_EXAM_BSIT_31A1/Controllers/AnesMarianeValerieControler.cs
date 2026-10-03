
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Anes, Mariane Valerie")]
    public class AnesMarianeValerieController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Anes, Mariane Valerie",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I am an Information Technology student at Lyceum of Alabang with a passion for software development, web technologies, and continuous learning. I enjoy building applications that are functional, user-friendly, and designed to solve real-world problems.",
                PhotoPath = "~/images/Anes.jpg",
                Email = "anesmariane@gmail.com",
                GitHubUrl = "https://github.com/Mariane-02",
                Skills = new List<string>
                {
                    "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Student Management System – Procedural Core",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Mariane-02/BSIT31E1_PRELIM_H1-ANES_MARIANE.git",
                        Description = "A console application built using procedural programming principles to manage student records, calculate course grade averages, and monitor academic performance.",
                        TechStack = new List<string> { "C#", "Procedural Programming" }
                    },
                    new ProjectItem
                    {
                        Title = "File Ingestion Engine",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Mariane-02/-BSIT31E1_PRELIM_H2_Anes_Mariane-Valerie.git",
                        Description = "A flexible backend utility that uses the Strategy and Factory design patterns to simplify parsing multiple file formats, transforming character streams, and validating data schemas.",
                        TechStack = new List<string> { "C#", "Design Patterns" }
                    },
                    new ProjectItem
                    {
                        Title = "FizzBuzz Logic Evaluation",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Mariane-02/BSIT31E1_PRELIM_A1_ANES_MARIANE.git",
                        Description = "A console application that showcases control flow design, nested conditional logic, and modulo-based calculations to generate sequential numeric outputs.",
                        TechStack = new List<string> { "C#", "Console Application" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/Mariane-02/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Anes_Mariane.git",
                        Description = "Prefinal examination project for IT Elective 2 demonstrating concepts and skills covered up to the prefinal period.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "HTTP Client Starter",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Mariane-02/IT_ELECTIVE_2_PRELIM_EXAM_ANES_MARIANEVALERIE.git",
                        Description = "A lightweight ASP.NET Core Web API setup that configures dependency injection, HTTP request routing middleware, typed HTTP clients, and JSON controller endpoints.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "HttpClient", "JSON" }
                    },
                }
            };

            return View(profile);
        }
    }
}