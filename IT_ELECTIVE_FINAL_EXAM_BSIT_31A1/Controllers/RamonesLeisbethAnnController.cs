using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Ramones, Leisbeth Ann")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class RamonesLeisbethAnn : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Leisbeth Ann Ramones",
                Tagline = "Novice Programmer",
                Course = "BS Information Technology",
                Section = "3A",
                Bio = "A passionate artist and animator, also a casual gamer. Aspiring to create a visual novel in the future, along being a content creator",
                PhotoPath = "~/images/RamonesPic.jpg",
                Email = "leisbethRamones@gmail.com",
                GitHubUrl = "https://github.com/eririii2",
                LinkedInUrl = "https://www.linkedin.com/in/leisbeth-ann-ramones-554bb9422/",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Student Management System – Procedural Core : Prelim H1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_H1_RAMONES_LEISBETHANN.git",
                        Description = "A console-based Student Management System developed using C#.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "GitHub Desktop, Visual Studio, and C# - FizzBuzz Challenge : Prelim A1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/eririii2/BSIT31E1_Prelim_A1_Ramones-Leisbeth-Ann.git",
                        Description = "A C# console application that generates the FizzBuzz sequence from 1 to 100.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Visual Studio Git Repository, GitHub Desktop, C# Calculator Challenge : Prelim A2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_A2_RAMONESLEISBETHANN.git",
                        Description = "A C# console-based calculator that calculates addition, subtraction, multiplication, and division.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "File Ingestion Engine : Prelim H2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_H2_Ramones_LeisbethAnn.git",
                        Description = "A C# application that implements different files like XML, JSON, and CSV.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Pair Activity : Prelim H3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PRELIM_H1_EULLO_JOHNRAVEN.git",
                        Description = "A C# application that improve the Student Management System's structure and organization of the original application.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Quiz",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_Q1_RAMONES_LEISBETH-ANN.git",
                        Description = "A C# application that demonstrates programming through using classes, inheritance, interfaces, and polymorphism.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "API with HTTP methods : Prelim A3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_H3_Ramones_LeisbethAnn.git",
                        Description = "A C# console application that demonstrates communication with an API using HTTP methods.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "OOP & HttpClient Concepts : Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_PRELIM_EXAM_RAMONES_LEISBETH.git",
                        Description = "A C# application of an object-oriented programming and HttpClient concepts",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Personal Portfolio ASP.NET Core MVC 1 : Midterm A1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_Midterm_A1_Ramones_LeisbethAnn.git",
                        Description = "A personal portfolio website developed using ASP.NET Core MVC, implementing the MVC architecture, Razor Views, shared layout customization, and responsive UI design using Bootstrap 5.",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Personal Portfolio ASP.NET Core MVC 2 : Midterm A2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_Midterm_A1_Ramones_LeisbethAnn.git",
                        Description = "A personal portfolio website developed using ASP.NET Core MVC, a continuation of implementing the MVC architecture, Razor Views, shared layout customization, and responsive UI design using Bootstrap 5.",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Login Page : Midterm Project",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/eririii2/-IT_ELECTIVE_BSIT_BSIT31E1_Ramones_LeisbethAnn.git",
                        Description = "A simple login application developed using ASP.NET Core MVC",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Playlist : Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/eririii2/-IT_ELECTIVE_2_MIDTERM_Q2_Ramones_LeisbethAnn.git",
                        Description = "An authenticated ASP.NET Core MVC application that allows users to manage a YouTube playlist.",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Login Form Requirements - Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_MIDTERM_Q3_Ramones_LeisbethAnn.git",
                        Description = "A login form application that limits users to three login attempts and requiring a minimum of six characters for the input.",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Ramones' Tech Hardware : Midterm H1, H2, H3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Ramones_LeisbethAnn.git",
                        Description = "An ASP.NET Core MVC Point of Sale web application designed for a small retail store.",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Vehicle Service Monitoring : Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_MIDTERM_EXAM_RAMONES_LEISBETHANN.git",
                        Description = "A web-based Vehicle Service Monitoring System that allows users to register vehicles and monitor service jobs.",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },
                    new ProjectItem
                    {
                        Title = "Web System and Technologies Exam : Prefinal Exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Ramones_LeisbethAnn.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "A web-based Prefinal Examination, an already included questions and answers.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "Personal Portfolio - Prefinal Quiz",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/eririii2/IT_ELECTIVE_2_BSIT31E1_PREFINAL_QUIZ_Ramones_LeisbethAnn.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "A web-based personal portfolio, including system's info, picture, github link, and a comment input",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    }
                }
            };

            return View(profile);
        }
    }
}