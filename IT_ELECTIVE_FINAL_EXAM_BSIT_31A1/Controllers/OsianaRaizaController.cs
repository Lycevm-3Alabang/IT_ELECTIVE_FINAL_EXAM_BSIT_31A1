using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Osiana Raiza Mae S.")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class OsianaRaizaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Osiana, Raiza Mae S.",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "Hi, Im Raiza, and I'm passionate about gaming, painting, Cosplaying and creating new things. For me, building something means turning ideas and imagination into something meaningful that the others can enjoy and experience" +
                "My goal is to create my own games, improve my creative Skills, and travel around the world while discovering new experience and inspiration.",
                PhotoPath = "images/Osiana.jpg",
                Email = "maemaekuroshiro@mail.com",
                GitHubUrl = "https://github.com/raizaosiana",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Project Error Handler",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/raizaosiana/BSIT31E1_PRELIM_A2_Osiana_RaizaMae.git",
                        Description = "This Activity is focuses on a holding or creating a error handler that can detect and manage error in a program.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                     new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/raizaosiana/Osiana_raizamae_prelim_exam1.git",
                        Description = "This Project is for the Prelim Examination.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Project Quiz ",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/raizaosiana/IT_ELECTIVE_2_MIDTERM_Q3.git",
                        Description = "This Project allow us to forked and to create Login, Logout (with navbar) Forget Password, Change Password, Lock user (after 3 attempts).",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                     new ProjectItem
                    {
                        Title = "Prelim Activities",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/raizaosiana/LabActivities_OSIANA.git",
                        Description = "",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                     new ProjectItem
                    {
                        Title = "Pre-Final Project Groupings ",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/jeromearejola-30/IT_ELECTIVE_PREFINALS_PROJECT.git",
                        Description = "",
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