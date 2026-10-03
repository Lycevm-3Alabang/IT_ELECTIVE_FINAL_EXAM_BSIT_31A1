using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Garcia, Lorainne")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class GarciaLorainneController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Garcia, Lorainne",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "E1",
                Bio = "I am an Information Technology student passionate about software development and modern web technologies. I enjoy building practical web applications and backend systems using C# and ASP.NET Core. My goal is to become a proficient full-stack developer and build reliable, user-centered digital solutions.",
                PhotoPath = "~/images/Garcia.jpg",
                Email = "lorainnemanuel01@gmail.com",
                GitHubUrl = "https://github.com/lorainnemanuel01-alt/IT_ELECTIVE_PREFINALS_PROJECT.git",
                LinkedInUrl = "https://github.com/lorainnemanuel01-alt/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Garcia_Lorainne.git",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Student Management System",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/lorainnemanuel01-alt/BSIT31E1_Prelim_A3_Garcia_Lorainne.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "Console app for managing student records, grades, and class averages.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Pixel & Meeple POS",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/lorainnemanuel01-alt/ModelBindingAssignment.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "Point-of-sale web app.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "BSIT-31E1 Final Project",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/lorainnemanuel01-alt/IT_ELECTIVE_PREFINALS_PROJECT.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "MVC Website.",
                        TechStack = new List<string> { "ASP.NET Core", "C#", "OAuth / SSO" }
                    }
                }
            };

            return View(profile);
        }
    }
}