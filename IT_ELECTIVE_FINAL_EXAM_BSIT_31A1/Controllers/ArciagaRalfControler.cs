using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Arciaga, Ralf")]
    public class ArciagaRalfController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Ralf Alean Majore C. Arciaga",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31A1",
                Bio = "I’m a curious and creative person who enjoys exploring technology, learning new skills, and building useful projects. I’m passionate about turning ideas into practical solutions and continuously improving along the way. My goal is to keep growing, create meaningful work, and make a positive impact through what I build.",
                PhotoPath = "~/images/RalfArciaga.jpg",
                Email = "arciaga.ralfmajore@gmail.com",
                GitHubUrl = "https://github.com/arciagaralfmajore-sketch?tab=repositories",
                LinkedInUrl = "https://github.com/arciagaralfmajore-sketch",

                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET Core MVC",
                    "SQL",
                    "HTML/CSS",
                    "Git"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/BSIT31E1_PRELIMA1_ARCIAGA_RALF.git",
                        Description = "BSIT31E1_PRELIMA1_ARCIAGA_RALF.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/BSIT31E1_PRELIM_A2_Arciaga_Ralf.git",
                        Description = "BSIT31E1_PRELIM_A2_Arciaga_Ralf.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/BSIT31E1_PRELIM_H1_Arciaga_Ralf.git",
                        Description = "BSIT31E1_PRELIM_H1_Arciaga_Ralf.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 4",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/BSIT31EE1_PRELIM_H1_Arciaga_Ralf.git",
                        Description = "BSIT31EE1_PRELIM_H1_Arciaga_Ralf.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 5",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/-BSIT31E1_PRELIM_H2_Arciaga_Ralf.git",
                        Description = "-BSIT31E1_PRELIM_H2_Arciaga_Ralf.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 6",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "HttpClientStarter",
                        Description = "HttpClientStarter.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 7",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_PRELIM_EXAM.git",
                        Description = "IT_ELECTIVE_2_PRELIM_EXAM.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 8",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_EXAM_PRELIM_ARCIAGA.git",
                        Description = "IT_ELECTIVE_EXAM_PRELIM_ARCIAGA\r\n.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Activity 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_Assignment_One.git",
                        Description = "IT_ELECTIVE_2_Assignment_One.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Activity 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_BSIT_BSIT31E1_ARCIAGA_RALFALEANAMJORE.git",
                        Description = "IT_ELECTIVE_BSIT_BSIT31E1_ARCIAGA_RALFALEANAMJORE\r\n.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Activity 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_MIDTERM_Q3.git",
                        Description = "IT_ELECTIVE_2_MIDTERM_Q3.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Activity 4",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                        Description = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Activity 5",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_MIDTERM_EXAM_set_1_Arciaga_Ralf.git",
                        Description = "IT_ELECTIVE_2_MIDTERM_EXAM_set_1_Arciaga_Ralf\r\n.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Activity 6",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_MIDTERM_Q2_Arciaga_Ralf.git",
                        Description = "IT_ELECTIVE_2_MIDTERM_Q2_Arciaga_Ralf.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Activity 1",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_ACTIVITY.git",
                        Description = "IT_ELECTIVE_2_ACTIVITY.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Activity 2",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Arciaga_Ralf.git",
                        Description = "IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Arciaga_Ralf.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Activity 3",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/arciagaralfmajore-sketch/Arciaga-ModernPortfolioMVC.git",
                        Description = "Arciaga-ModernPortfolioMVC.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    }
                }
            };

            return View(profile);
        }
    }
}