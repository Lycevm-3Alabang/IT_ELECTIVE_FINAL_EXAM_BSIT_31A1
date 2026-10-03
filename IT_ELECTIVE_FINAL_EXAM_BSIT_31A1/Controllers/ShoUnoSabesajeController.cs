using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Sabesaje, Sho Uno")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class ShoUnoSabesajeController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Sho Uno Sabesaje",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I am a dedicated software developer passionate about building clean, efficient applications and solving complex problems.",
                PhotoPath = "~/images/Sabesaje.jpg",
                Email = "constantinoshouno@gmail.com",
                GitHubUrl = "https://github.com/ShoIchiiii",
                LinkedInUrl = "https://www.linkedin.com/in/sho-uno-constantino-8109852a7/",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
               {
    new ProjectItem
    {
        Title = "IT Elective 2 - Prefinal Exam",
        Stage = ProjectStage.PreFinal,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_SABESAJE_SHO_UNO.git",
        Description = "Prefinal examination project for IT Elective 2 demonstrating concepts and skills covered up to the prefinal period.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "BSIT31E1 - Prelim H1",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/BSIT31E1_PRELIM_H1_SABESAJE_SHO.git",
        Description = "A prelim-period homework activity focused on applying foundational programming and application development concepts.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective - BSIT 31E1 Project",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_BSIT_31E1_Sabesaje_ShoUno.git",
        Description = "A course project for IT Elective showcasing application development skills built throughout the term.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective 2 - Midterm Exam #4",
        Stage = ProjectStage.Midterm,
        RepoUrl = "https://github.com/ShoIchiiii/-IT_ELECTIVE_2_MIDTERM_EXAM_4_Sabesaje_ShoUno.git",
        Description = "Submitted as Midterm Exam #4 for IT Elective 2, applying concepts learned during the midterm period.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective 2 - Assignment One",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ninalamo/IT_ELECTIVE_2_Assignment_One.git",
        Description = "An assignment project for IT Elective 2, collaboratively worked on and hosted under a classmate/group repository.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "BSIT31E1 - Prelim A2",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/BSIT31E1_PRELIM_A2_Sabesaje_ShoUno.git",
        Description = "A prelim-period activity submitted for BSIT31E1, building on earlier coursework and expanding application features.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "BSIT31E1 - Prelim A3",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/BSIT31E1_PreLim_A3_Sabesaje_ShoUno.git",
        Description = "A prelim-period activity continuing the progression of skills developed in prior prelim activities.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "BSIT31E1 - A1 Prelim",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/BSIT31E1_A1PreLim_Sabesaje-ShoUno.git",
        Description = "The first prelim-period activity submitted for BSIT31E1, establishing the foundation for later assignments.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective - Prefinal A1",
        Stage = ProjectStage.PreFinal,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_PREFINAL_A1_SABESAJE.git",
        Description = "A prefinal-period activity applying more advanced concepts covered near the end of the term.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective 2 - Midterm H1, H2, H3",
        Stage = ProjectStage.Midterm,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Sabesaje.git",
        Description = "A collection of midterm-period homework activities (H1-H3) showcasing progressive feature development.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective 2 - Midterm Q3",
        Stage = ProjectStage.Midterm,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_2_MIDTERM_Q3_Sabesaje.git",
        Description = "A midterm-period quiz project testing applied knowledge of concepts covered during that portion of the course.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective 2 - Midterm Q2",
        Stage = ProjectStage.Midterm,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_2_MIDTERM_Q2_Sabesaje_ShoUno.git",
        Description = "A midterm-period quiz project demonstrating application development skills.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective 2 - Midterm A1",
        Stage = ProjectStage.Midterm,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_2_Midterm_A1_Sabesaje_ShoUno.git",
        Description = "The first midterm-period activity covering core concepts introduced at the start of midterm coursework.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective 2 - Prelim Exam",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/IT_ELECTIVE_2_PRELIM_EXAM_Sabesaje_ShoUno.git",
        Description = "Submitted as the prelim exam for IT Elective 2 assessing foundational skills.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "BSIT31E1 - Prelim Q1",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/BSIT_31E1_PRELIM_Q1_Sabesaje_ShoUno.git",
        Description = "A prelim-period quiz project testing early concepts taught in the course.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "BSIT31E1 - Prelim H2",
        Stage = ProjectStage.Prelim,
        RepoUrl = "https://github.com/ShoIchiiii/BSIT31E1_PRELIM_H2_SABESAJE_SHO.git",
        Description = "A prelim-period homework activity continuing from the concepts introduced in H1.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    },
    new ProjectItem
    {
        Title = "IT Elective Prefinals Project",
        Stage = ProjectStage.PreFinal,
        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_PREFINALS_PROJECT.git",
        Description = "A prefinal-period collaborative project developed and hosted under a group repository.",
        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
    }
}
            };

            return View(profile);
        }
    }
}