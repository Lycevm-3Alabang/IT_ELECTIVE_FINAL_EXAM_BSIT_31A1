using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Pacaonces, Janssen")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class PacaoncesJanssenController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Pacaonces Janssen",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "BSIT31E1",
                Bio = "I like building systems and my goal is to be a full-stack developer.",
                PhotoPath = "~/images/janssen.jpg",
                Email = "janssen.m.pacaonces@gmail.com",
                GitHubUrl = "https://github.com/your-username",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_Prelim_Assignment_One_Grading_Calculator",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/jpacaonces/ite-two-prelim-assignment-one",
                        Description = "This project is a grading system calculator using MVC.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_Prelim_Assignment_Two_File Ingestion Engine",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/jpacaonces/ite-two-prelim-assignment-two.",
                        Description = "This MVC project demonstrates file reading.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_EXAM",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/jpacaonces/IT_ELECTIVE_2_MIDTERM_EXAM_4_janssenpacaonces",
                        Description = "Database creation with MVC.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_Q3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/jpacaonces/IT_ELECTIVE_2_MIDTERM_Q3",
                        Description = "Login Page project with MVC.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/jpacaonces/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Pacaonces_Janssen",
                        Description = "Examination with question and answers using MVC.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/jpacaonces/IT_ELECTIVE_2_MIDTERM_Q3",
                        Description = "Login Page project with MVC.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },

                  
                }
            };

            return View(profile);
        }
    }
}