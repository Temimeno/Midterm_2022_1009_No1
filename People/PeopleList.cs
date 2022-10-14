using System.Collections.Generic;

class PeopleList {

    static Program program;
    private List<Collegian> collegianlist;
    private List<Student> studentlist;
    private List<Teacher> teacherlist;

    public PeopleList() {
        this.collegianlist = new List<Collegian>();
        this.studentlist = new List<Student>();
        this.teacherlist = new List<Teacher>(); 
    }

    public void AddNewCollegian(Collegian collegian) {
        this.collegianlist.Add(collegian);
    }

    public void AddNewStudent(Student student) {
        this.studentlist.Add(student);
    }

    public void AddNewTeacher(Teacher teacher) {
        this.teacherlist.Add(teacher);
    }

    public Collegian CheckEmail(string email) {
        foreach(Collegian collegian in collegianlist) {
            if (collegian.GetEmail().Equals(email)) {
                return collegian;
            }
        }

        return null;
    }

    public Collegian CheckPassword(string password) {
        foreach(Collegian collegian in collegianlist) {
            if (collegian.GetPassword().Equals(password)) {
                return collegian;
            }
        }

        return null;
    }

    public Collegian LoginCheck(Collegian checker) {
        foreach(Collegian collegian in collegianlist) {
            string email = checker.GetEmail();
            string password = checker.GetPassword();

            if (collegian.GetEmail().Equals(email) && (collegian.GetPassword().Equals(password))) {
                return collegian;
            }
        }

        return null;
    }

    public void CountStat() {
        Console.WriteLine("Number of Current Collegian : {0}", collegianlist.Count());
        Console.WriteLine("Number of Student : {0}", studentlist.Count());
        Console.WriteLine("Number of Teacher : {0}", teacherlist.Count());
    }
    public void FetchCollegianList() {
        Console.WriteLine("Current Collegian List");
        Console.WriteLine("***********************");

        foreach(Collegian collegian in this.collegianlist) {
            if (collegian is Collegian) {
                Console.WriteLine("Type: Collegian");
                Console.WriteLine("\n Prefix : {0}", collegian.GetName_prefix());
                Console.WriteLine(" Name : {0}", collegian.GetName());
                Console.WriteLine(" Surname : {0}", collegian.GetSurname());
                Console.WriteLine();
            }
        }
    }

    public void FetchStudentList() {
        Console.WriteLine("Student List");
        Console.WriteLine("***********************");

        foreach(Student student in this.studentlist) {
            if (student is Student) {
                Console.WriteLine("Type: Student");
                Console.WriteLine("\n Prefix : {0}", student.GetName_prefix());
                Console.WriteLine(" Name : {0}", student.GetName());
                Console.WriteLine(" Surname : {0}", student.GetSurname());
                Console.WriteLine();
            }
        }
    }

    public void FetchTeacherList() {
        Console.WriteLine("Teacher List");
        Console.WriteLine("***********************");

        foreach(Teacher teacher in this.teacherlist) {
            if (teacher is Teacher) {
                Console.WriteLine("Type: Teacher");
                Console.WriteLine("\n Prefix : {0}", teacher.GetName_prefix());
                Console.WriteLine(" Name : {0}", teacher.GetName());
                Console.WriteLine(" Surname : {0}", teacher.GetSurname());
                Console.WriteLine();
            }
        }
    }
}