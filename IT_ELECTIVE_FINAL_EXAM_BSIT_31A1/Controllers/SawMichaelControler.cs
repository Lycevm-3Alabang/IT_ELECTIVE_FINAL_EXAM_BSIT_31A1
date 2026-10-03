using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Saw,Michael Jelbert C.")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class SawMichaelController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Saw, Michael Jelbert C.",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I am a versatile IT student driven by a passion for exploring complex ideas, solving creative problems, and turning abstract concepts into practical solutions. This portfolio showcases my complete coursework, hands-on labs, and exams from Prelims to Pre-Finals following the Model-View-Controller (MVC) pattern.",
                PhotoPath = "~",
                Email = "sawmichael32@gmail.com",
                GitHubUrl = "https://github.com/sawmichael32-ctrl",
                LinkedInUrl = "https://github.com/sawmichael32-ctrl",
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Pre-Final order
                Projects = new List<ProjectItem>
                {
                    // ================= PRELIM =================
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_PRELIM_EXAM.git",
                        Description = "Comprehensive examination project demonstrating core programming logic during the prelim period.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "HTTP Client Starter",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/HttpClientStarter-1.git",
                        Description = "Starter project and hands-on implementation for managing HTTP requests and API communication.",
                        TechStack = new List<string> { "C#", "HTTP" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-on 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/BSIT31E1_PRELIM_H2_Saw_Michael.git",
                        Description = "Hands-on laboratory activity focusing on structured data handling and logic execution.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Assignment 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/BSIT31E1_PRELIM_A2_Saw_Michael-Jelbert.git",
                        Description = "Assigned task evaluating algorithmic problem-solving and foundational syntax.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Assignment 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/BSIT31E1_PRELIM_A1_SAW_MICHAEL.git",
                        Description = "Initial introductory programming task setting up the development workflow and environment.",
                        TechStack = new List<string> { "C#" }
                    },

                    // ================= MIDTERM =================
                    new ProjectItem
                    {
                        Title = "Midterm Exam 7",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_MIDTERM_EXAM_7_Saw_Michael.git",
                        Description = "Major midterm exam project showcasing intermediate features, data structures, and application structure.",
                        TechStack = new List<string> { "C#", "ASP.NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Q3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_MIDTERM_Q3.git",
                        Description = "Targeted quiz and task submission addressing core intermediate concepts.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Hands-on (H1-H3)",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                        Description = "Series of hands-on lab exercises (H1, H2, H3) building intermediate functional modules.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Template",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_TEMPLATE.git",
                        Description = "Boilerplate project template utilized across midterm coding laboratory activities.",
                        TechStack = new List<string> { "C#", "MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "BSIT Base Portfolio Project",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_BSIT_BSIT31E1_Saw_MichaelJelbert.git",
                        Description = "Foundational portfolio structure built and organized during the midterm grading period.",
                        TechStack = new List<string> { "C#", "HTML/CSS" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Assignment 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_Assignment_One.git",
                        Description = "Assignment focused on solidifying intermediate application development patterns.",
                        TechStack = new List<string> { "C#" }
                    },

                    // ================= PRE-FINAL =================
                    new ProjectItem
                    {
                        Title = "Modern Portfolio MVC",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/Saw-ModernPortfolioMVC.git",
                        Description = "Main web application portfolio built using the Model-View-Controller architecture to display all works.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Bootstrap" }
                    },
                    new ProjectItem
                    {
                        Title = "Pre-Final Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_SAW_MICHAEL.git",
                        Description = "Advanced practical examination demonstrating end-to-end MVC architecture implementation.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Pre-Final Assignment 1",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/sawmichael32-ctrl/IT_ELECTIVE_2_A1_PREFINALS_SAW_MICHAEL.git",
                        Description = "Pre-final assignment centering on advanced web routing, view rendering, and data modeling.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#" }
                    }
                }
            };

            return View(profile);
        }
    }
}