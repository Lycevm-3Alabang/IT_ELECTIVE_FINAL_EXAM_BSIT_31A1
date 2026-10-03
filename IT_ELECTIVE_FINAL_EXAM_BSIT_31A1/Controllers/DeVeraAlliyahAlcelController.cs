using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("De Vera, Alliyah Alcel")] 
    public class DeVeraAlliyahAlcelController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Alliyah Alcel G. De Vera",
                Tagline = "Aspiring UI/UX Designer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "secret no clue",
                PhotoPath = "~/images/ally.jpg",
                Email = "alliyahalceldevera@email.com",
                GitHubUrl = "https://github.com/alliyahdevera",
                LinkedInUrl = "https://linkedin.com/in/alliyahdevera",  
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "MySQL", "HTML/CSS", "Adobe Premiere Pro" },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Registrar Document Request System",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/alliyahdevera/Registrar_Document_Request_System",
                        LiveUrl = null,
                        Description = "A VB.NET and MySQL system for managing student document requests, payments, and release status. It helps a registrar's office manage students, document types, requests, payments, and document release tracking.",
                        TechStack = new List<string> { "VB.NET", "Windows Forms", "MySQL" }
                    },
                    new ProjectItem
                    {
                        Title = "MVC Authentication System",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_Q3_DEVERA_ALLIYAH",
                        LiveUrl = null,
                        Description = "A hardcoded-login ASP.NET Core MVC application with cookie authentication, password reset, and account lockout after failed login attempts.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Cookie Authentication" }
                    },
                    new ProjectItem
                    {
                        Title = "Help Desk Ticketing System",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_PREFINALS_PROJECT",
                        LiveUrl = null,
                        Description = "A collaborative ASP.NET Core MVC and EF Core system for managing support tickets, customers, employees, and ticket comments.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "EF Core", "C#", "SQL Server" }
                    },
                    new ProjectItem
                    {
                        Title = "IT Elective 2 PreFinal Examination Website",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_DeVera_Alliyah",
                        LiveUrl = null,
                        Description = "An ASP.NET Core MVC website created for the IT Elective 2 PreFinal Examination that organizes exam topics, questions, and their corresponding answers.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Razor Views" }
                    },
                    new ProjectItem
                    {
                        Title = "Package Pickup Monitoring System",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_EXAM_6_DEVERA_ALLIYAH",
                        LiveUrl = null,
                        Description = "An ASP.NET Core MVC application for recording, monitoring, and managing incoming packages and their pickup status. It includes CRUD operations, search, validation, cookie authentication, Razor Views, Bootstrap, and an in-memory repository.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Bootstrap", "Razor Views" }
                    },
                    new ProjectItem
                    {
                        Title = "Dream Bake POS",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_DEVERA_ALLIYAH",
                        LiveUrl = null,
                        Description = "A bakery-themed ASP.NET Core MVC Point of Sale application that allows cashiers to browse bakery products, add items to a cart, enter customer information, calculate orders, and complete transactions.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Bootstrap", "In-Memory Repository" }
                    },
                    new ProjectItem
                    {
                        Title = "MusicSpace",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_Q1",
                        LiveUrl = null,
                        Description = "An ASP.NET Core MVC music playlist application where users can log in, build personal playlists using YouTube songs, play songs through an embedded YouTube player, and view a Top 5 Trending Songs list based on play counts.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "YouTube", "Bootstrap" }
                    },
                    new ProjectItem
                    {
                        Title = "Playlistify",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_Q2_DEVERA_ALLIYAH",
                        LiveUrl = null,
                        Description = "A session-based ASP.NET Core MVC playlist manager where users can log in, create shareable YouTube playlists, and add optional notes to each track. Playlist rows can be added or removed server-side without JavaScript.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Session Authentication", "Razor Views" }
                    }
                }
            };

            return View(profile);
        }
    }
}