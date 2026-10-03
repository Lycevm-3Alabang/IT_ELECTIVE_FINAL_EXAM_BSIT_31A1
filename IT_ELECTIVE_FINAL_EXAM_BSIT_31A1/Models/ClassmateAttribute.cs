namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models
{
    // Marks a controller as a classmate's portfolio so Home can find it automatically.
    [AttributeUsage(AttributeTargets.Class)]
    public class ClassmateAttribute : Attribute
    {
        public string Name { get; }
        public ClassmateAttribute(string name) => Name = name;
    }
}