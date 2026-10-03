using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Solis, Sophia Cassandra")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class SolisSophiaCassandraController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Sophia Cassandra Solis",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I'm an aspiring developer who loves creating web apps and working with databases. My goal is to keep learning C# and modern tech to build simple, useful software.",
                PhotoPath = "~/images/SolisSophiaCassandra.png",
                Email = "sophixcassandra@email.com",
                GitHubUrl = "https://github.com/SolisSophiaCassandra",
                LinkedInUrl = "https://linkedin.com/in/sophia-cassandra-solis",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                   new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Exam 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/IT_ELECTIVE_2_MIDTERM_EXAM_1_Solis_Sophia_Cassandra.git",
                        Description = "Vehicle Service Monitoring System console application built for Midterm Exam 1.",
                        TechStack = new List<string> { "C#", "Console", "OOP" }
                    },
                    new ProjectItem
                    {
                        Title = "ASP.NET Core MVC Model Binding",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/IT_ELECTIVE_BSIT_31E1_Solis_Sophia_Cassandra",
                        Description = "A simple Login Page application demonstrating Model Binding, Data Annotations, and ModelState validation without a database.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Data Annotations" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Prefinal Activity 1",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/IT_ELECTIVE_2_PREFINAL_ACTIVITY_1_SOLIS",
                        Description = "Prefinal practical assignment implementing database connectivity and UI models.",
                        TechStack = new List<string> { "ASP.NET Core", "SQL / Database", "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "BSIT 31E1 - Midterm Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/BSIT_31E1_PRELIM_Q1_SOLIS_SOPHIA_CASSANDRA.git",
                        Description = "First quiz assessment on baseline C# programming fundamentals, data types, and syntax.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/IT_ELECTIVE_2_MIDTERM_Q2_Solis_Sophia_Cassandra.git",
                        Description = "Second midterm quiz project demonstrating C# control structures and algorithmic evaluation.",
                        TechStack = new List<string> { "C#", "Console", "Control Flow" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/IT_ELECTIVE_2_MIDTERM_Q3_Solis_Sophia_Cassandra.git",
                        Description = "Third midterm quiz focused on object-oriented programming structures and class encapsulation.",
                        TechStack = new List<string> { "C#", "OOP Encapsulation" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Hands-On 1, 2 & 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Solis_Sophia_Cassandra.git",
                        Description = "Consolidated midterm hands-on series featuring interactive C# console applications covering user input and arrays.",
                        TechStack = new List<string> { "C#", "Console", "Arrays & Loops" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 - Midterm Activity 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/SolisSophiaCassandra/IT_ELECTIVE_2_Midterm_A1_Solis_Sophia_Cassandra.git",
                        Description = "First midterm activity covering fundamental Web/MVC routing and object initialization.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C# Routing" }
                    }
                }
            };

            return View(profile);
        }
    }
}