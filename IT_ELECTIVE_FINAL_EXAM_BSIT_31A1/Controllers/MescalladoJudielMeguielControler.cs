using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Mescallado, Judiel Meguiel")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class MescalladoJudielMeguielControler : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Judiel Meguiel Mescallado",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "Antagonist",
                PhotoPath = "~/images/me.jpg",
                Email = "mjudielmeguiel@email.com",
                GitHubUrl = "https://github.com/mjudielmeguiel",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "BSIT31E1_PRELIM_A1_Mescallado_Judiel_Meguiel",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/mjudielmeguiel/BSIT31E1_PRELIM_A1_Mescallado_Judiel_Meguiel.git",
                        Description = "1",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "BSIT31E1_PRELIM_H2_Mescallado_Judiel",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/mjudielmeguiel/BSIT31E1_PRELIM_H2_Mescallado_Judiel.git",
                        Description = "2",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                     new ProjectItem
                    {
                        Title = "First_MVC_Application",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/mjudielmeguiel/First_MVC_Application.git",
                        Description = "2",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                     new ProjectItem
                    {
                        Title = "BSIT31E1_PRELIM_H1_MESCALLADO_JUDIEL_MEGUIEL",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/mjudielmeguiel/BSIT31E1_PRELIM_H1_MESCALLADO_JUDIEL_MEGUIEL.git",
                        Description = "2",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                     new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_PRELIM_EXAM",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/mjudielmeguiel/IT_ELECTIVE_2_PRELIM_EXAM.git",
                        Description = "2",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_Assignment_One",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/mjudielmeguiel/IT_ELECTIVE_2_Assignment_One.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "Polling_App",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/mjudielmeguiel/Polling_App.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_BSIT_-31E1-_-Mescallado_Judiel_Meguiel",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/mjudielmeguiel/IT_ELECTIVE_BSIT_-31E1-_-Mescallado_Judiel_Meguiel-.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_Q2_Meguel_Mjudiel",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/mjudielmeguiel/IT_ELECTIVE_2_MIDTERM_Q2_Meguel_Mjudiel.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_Q3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/mjudielmeguiel/IT_ELECTIVE_2_MIDTERM_Q3.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/mjudielmeguiel/IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "Q3-Midterm",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/mjudielmeguiel/Q3-Midterm.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                }
            };

            return View(profile);
        }
    }
}