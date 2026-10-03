
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Rollano, Kristopher Rj")]
    public class RollanoKristopherController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Kristopher Rj L. Rollano",

                Tagline = "Aspiring Full-Stack Developer",

                Course = "BS Information Technology",

                Section = "BSIT31E1",

                Bio = "I am a BS Information Technology student interested in building responsive web applications, "
                    + "desktop systems, and database-driven solutions. I enjoy working with C#, ASP.NET Core MVC, "
                    + "VB.NET, MySQL, and modern web technologies while continuously improving my programming and "
                    + "software development skills.",

                PhotoPath = "~/images/Krist.png",

                Email = "kristopher@email.com",

                GitHubUrl = "https://github.com/RollanoKristopher",

                LinkedInUrl = null,

                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET Core MVC",
                    "VB.NET",
                    "WinForms",
                    "MySQL",
                    "SQL",
                    "HTML/CSS",
                    "JavaScript",
                    "PHP",
                    "Entity Framework Core",
                    "Git",
                    "GitHub"
                },

                // ============================================================
                // PROJECTS
                // Prelim → Midterm → Final
                // ============================================================
                Projects = new List<ProjectItem>
                {
                    // ========================================================
                    // PRELIM PROJECTS
                    // ========================================================

                    new ProjectItem
                    {
                        Title = "Prelim Activity 1",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A1_Rollano_Kristopher-Rj",

                        Description =
                            "A BSIT31E1 Prelim Activity 1 coursework project demonstrating fundamental "
                            + "programming and software development concepts.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 2",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A2_Rollano_Kristopher-Rj",

                        Description =
                            "A BSIT31E1 Prelim Activity 2 coursework project.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 3",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A3_Rollano_Kristopher-Rj",

                        Description =
                            "A BSIT31E1 Prelim Activity 3 project focused on programming and application development.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Homework 1",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/RollanoKristopher/BSIT31E1_Prelim_H1_Rollano_Kristopher-Rj",

                        Description =
                            "A BSIT31E1 Prelim Homework 1 coursework repository.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Quiz 1",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/RollanoKristopher/BSIT_31E1_PRELIM_Q1_Rollano_Kristopher_Rj",

                        Description =
                            "A BSIT31E1 Prelim Quiz 1 coursework repository.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Homework 2",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_H2_Rollano_KristopherRj",

                        Description =
                            "A BSIT31E1 Prelim Homework 2 coursework repository.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 – Prelim Exam",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/RollanoKristopher/IT_ELECTIVE_2_PRELIM_EXAM_Rollano_Kristopher_Rj",

                        Description =
                            "IT Elective 2 Prelim Exam project covering C# programming, "
                            + "object-oriented programming, and application development.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "OOP"
                        }
                    },

                    // ========================================================
                    // MIDTERM PROJECTS
                    // ========================================================

                    new ProjectItem
                    {
                        Title = "IT Elective 2 – Midterm Activity 1",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/RollanoKristopher/IT_ELECTIVE_2_Midterm_A1_Rollano_Kristopher_Rj",

                        Description =
                            "An IT Elective 2 Midterm Activity 1 project demonstrating "
                            + "web development and ASP.NET Core MVC concepts.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML",
                            "CSS",
                            "Bootstrap"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "RSVP Web App",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/RollanoKristopher/RSVP-Web-APP",

                        Description =
                            "A personal RSVP web application developed outside of coursework.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML",
                            "CSS",
                            "JavaScript"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 – Midterm Quiz 2",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/RollanoKristopher/IT_ELECTIVE_2_MIDTERM_Q2_Rollano_KristopherRj",

                        Description =
                            "IT Elective 2 Midterm Quiz 2 coursework repository.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 – Midterm Homework 1–3",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/RollanoKristopher/IT_ELECTIVE_2_MIDTERM_H1_H2_H3",

                        Description =
                            "A collection of IT Elective 2 Midterm Homework activities.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "ASP.NET Core"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 – Midterm Quiz 3",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/RollanoKristopher/IT_ELECTIVE_2_MIDTERM_Q3",

                        Description =
                            "IT Elective 2 Midterm Quiz 3 coursework repository.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 – Midterm Exam",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/RollanoKristopher/IT_ELECTIVE_2_MIDTERM_EXAM_8_Rollano_Kristopher_Rj",

                        Description =
                            "IT Elective 2 Midterm Exam project demonstrating programming "
                            + "and web development concepts.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "OOP"
                        }
                    },

                    // ========================================================
                    // FINAL / MAJOR PROJECTS
                    // ========================================================

                    new ProjectItem
                    {
                        Title = "StudySync",

                        Stage = ProjectStage.Final,

                        RepoUrl = "https://github.com/your-username/studysync",

                        Description =
                            "An ASP.NET Core student productivity application for tracking assignments, "
                            + "exams, study sessions, class schedules, and academic workload. "
                            + "It includes a dashboard, calendar, task management, and Pomodoro-style "
                            + "focus timer.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "Entity Framework Core",
                            "SQLite",
                            "ASP.NET Identity",
                            "Bootstrap"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Registrar Document Request System",

                        Stage = ProjectStage.Final,

                        RepoUrl = "https://github.com/your-username/registrar-system",

                        Description =
                            "A VB.NET Windows Forms application backed by MySQL that helps a "
                            + "school registrar's office manage student document requests, "
                            + "payments, request statuses, receipts, and reports.",

                        TechStack = new List<string>
                        {
                            "VB.NET",
                            "WinForms",
                            ".NET Framework 4.8",
                            "MySQL"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "K-Sync",

                        Stage = ProjectStage.Final,

                        RepoUrl = "https://github.com/your-username/k-sync",

                        Description =
                            "A Korean BBQ restaurant management and self-ordering system featuring "
                            + "table seating, QR-based ordering, kitchen tickets, staff alerts, "
                            + "package-based menu access, and MySQL database integration.",

                        TechStack = new List<string>
                        {
                            "VB.NET",
                            "WinForms",
                            "PHP",
                            "JavaScript",
                            "MySQL",
                            "QR Codes"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Daily Life Expense Tracker",

                        Stage = ProjectStage.Final,

                        RepoUrl = "https://github.com/your-username/daily-life-expense-tracker",

                        Description =
                            "A VB.NET WinForms budgeting application for recording daily expenses, "
                            + "tracking budgets, viewing spending summaries, generating charts, "
                            + "and exporting reports to PDF.",

                        TechStack = new List<string>
                        {
                            "VB.NET",
                            "WinForms",
                            ".NET Framework 4.8",
                            "MySQL",
                            "iText PDF"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "Pre-Final Activity 1",

                        Stage = ProjectStage.Final,

                        RepoUrl = "https://github.com/RollanoKristopher/BSIT31E1_Act1_Pre-Final_Rollano_Kristopher",

                        Description =
                            "A BSIT31E1 Pre-Final Activity 1 coursework repository.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 – Prefinal Exam",

                        Stage = ProjectStage.Final,

                        RepoUrl = "https://github.com/RollanoKristopher/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Rollano_Kristopher",

                        Description =
                            "IT Elective 2 Pre-Final Exam coursework repository.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "SQL"
                        }
                    }
                }
            };

            return View(profile);
        }
    }
}
