class Course
{
    public string Name;
    public int MaxSeats;
    public Course(string name, int platser)
    {
        Name = name;
        MaxSeats = platser;
    }
    public List<Student> Students = new List<Student>();

    public void Enroll(Student student)
    {
        if (Students.Count < MaxSeats && !Students.Contains(student))
        {
            Students.Add(student);
            student.Courses.Add(this);
        }
    }

    public void Remove(Student student)
    {
        if (Students.Contains(student))
        {
            Students.Remove(student);
            student.Courses.Remove(this);
        }
    }

    public void RollCall()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}