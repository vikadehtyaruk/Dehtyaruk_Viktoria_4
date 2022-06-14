
ISschool school = new School(100,25,0,20);
ISschool university = new University(1000,30,0,0);
ISschool faculty = new Faculty(0,0,1971,15);
school.OutputStudents();
university.OutputStudents();
faculty.OutputYear();
school.OutputTeachers();
university.OutputTeachers();
school.OutputClas();

abstract class ISschool
{
    public int Countstu { get; set; }
    public int Countteach { get; set; }
    public int Year { get; set; }
    public int Clas { get; set; }

    public ISschool(int countstu, int countteach, int year,int clas) 
    {
        Countstu = countstu;
        Countteach = countteach;
        Year = year;
        Clas=clas;
    }
    public void OutputStudents() => Console.WriteLine($"{Countstu} студентiв");
    public void OutputYear() => Console.WriteLine($"Факультет заснований {Year} року");
    public void OutputTeachers() => Console.WriteLine($"Викладачів {Countteach}");
    public void OutputClas() => Console.WriteLine($"Класів/факультетів{Countteach}");
}
 class School : ISschool
{
    public School(int countstu, int countteach, int year,int clas) : base(countstu, countteach, year, clas) { }
}
 class University : ISschool
{
    public University(int countstu, int countteach, int year, int clas) : base(countstu, countteach, year, clas) { }
}
 class Faculty : ISschool
{
    public Faculty(int countstu, int countteach, int year, int clas) : base(countstu, countteach, year, clas) { }
}
