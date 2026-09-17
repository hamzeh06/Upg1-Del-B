class Student
{
    public string Name;
    public List <Course> Courses = new List <Course>();
    public Student(string name)
    {
        Name = name;
    }
    
    public void Join(Course course)
    {
        course.Enroll(this);
    }

    public void Leave(Course course)
    {
        course.Remove(this);
    }

    public void Schedule()
    {
        foreach (Course course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }

    public override string ToString()
    {
        return Name;
    }
}