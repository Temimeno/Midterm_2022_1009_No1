enum Menu {
    Register = 1,
    ShowAttendantStatistic = 2,
    Login = 3
}

enum Regis_ChooseTypeMenu {
    CurrentCollegian = 1,
    Student = 2,
    Teacher = 3
}

enum Menu2 {
    Register = 1,
    Show_All_Current_Collegian = 2,
    Show_All_Student = 3,
    Show_All_Teacher = 4,
    Logout = 5
}

public class Program {

    static PeopleList peopleList;
    static void Main(string[] args) {
        Console.Clear();
        PreparePeopleListWhenProgramIsLoad();

        PrintMenuBeforeLogin();
        InputMenuFromKeyboard();
    }

    //Before Login

    static void PrintMenuBeforeLogin() {
        Console.WriteLine("Welcome to Idia Camp 2022 Registration System");
        Console.WriteLine("**********************************************");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Show Attentdant Statistic");
        Console.WriteLine("3. Login");
        Console.WriteLine();
        Console.WriteLine("0. Exit");
        Console.WriteLine("**********************************************");
    }

    static void InputMenuFromKeyboard() {
        Console.Write("Please input Menu (Type in number): ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }

    static void PresentMenu(Menu menu) {
        switch (menu) {
            case Menu.Register:
            RegisterMenu();
            break;
            case Menu.ShowAttendantStatistic:
            ShowStat();
            break;
            case Menu.Login:
            Login();
            break;
        default:
            break;
        }
    }

    //Register

    static void RegisterMenu() {
        Console.Clear();

        PrintChooseRegisterType();
        InputRegisTypeFromKeyboard();
    }
    static void PrintChooseRegisterType() {
        Console.WriteLine("Choose Registration Type");
        Console.WriteLine("*************************");
        Console.WriteLine("1. Current Collegian");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("*************************");
    }

    static void InputRegisTypeFromKeyboard() {
        Console.Write("Please input Type (Type in number): ");
        Regis_ChooseTypeMenu type = (Regis_ChooseTypeMenu)(int.Parse(Console.ReadLine()));

        ChooseType(type);
    }

    static void ChooseType(Regis_ChooseTypeMenu type) {
        switch(type) {
            case Regis_ChooseTypeMenu.CurrentCollegian:
            InputInfoCollegian();
            break;
            case Regis_ChooseTypeMenu.Student:
            InputInfoStudent();
            break;
            case Regis_ChooseTypeMenu.Teacher:
            InputInfoTeacher();
            break;
        default:
            break;
        }
    }

    static void InputInfoCollegian() {
        Console.Clear();
        CollegianRegisHeader();

        Collegian collegian = new Collegian(InputName_Prefix(), InputName(), InputSurname(), InputAge(), InputCollegianID(),
                                            InputAllergy(), InputReligion(), AskIfAdmin(), InputEmail(), InputPassword());

        Program.peopleList.AddNewCollegian(collegian);

        BackToBeforeLogin();
    }

    static void InputInfoStudent() {
        Console.Clear();
        StudentRegisHeader();

        Student student = new Student(InputName_Prefix(), InputName(), InputSurname(), InputAge(), InputLevelOfEducation(), InputAllergy(), InputReligion(), InputSchool());

        Program.peopleList.AddNewStudent(student);

        BackToBeforeLogin();
    }

    static void InputInfoTeacher() {
        Console.Clear();
        TeacherRegisHeader();

        Teacher teacher = new Teacher(InputName_Prefix(), InputName(), InputSurname(), InputAge(), InputPosition(), InputAllergy(),
                                      InputReligion(), AskIfCar(), InputCarLicensePlate(), AskIfAdmin(), InputEmail(), InputPassword());

        Program.peopleList.AddNewTeacher(teacher);

        BackToBeforeLogin();
    }

    static void PreparePeopleListWhenProgramIsLoad() {
        Program.peopleList = new PeopleList();
    }

    static void BackToBeforeLogin() {
        Console.Clear();
        PrintMenuBeforeLogin();
        InputMenuFromKeyboard();
    }

    static void CollegianRegisHeader() {
        Console.WriteLine("Current Collegian Registration");
        Console.WriteLine("*******************************");
    }

    static void StudentRegisHeader() {
        Console.WriteLine("Student Registration");
        Console.WriteLine("*********************");
    }

    static void TeacherRegisHeader() {
        Console.WriteLine("Teacher Registration");
        Console.WriteLine("*********************");
    }

    static string InputName_Prefix() {
        Console.WriteLine("Choose your name prefix");
        Console.WriteLine(" - Mr.");
        Console.WriteLine(" - Mrs.");
        Console.WriteLine(" - Miss.");
        Console.Write("Please input Prefix : ");

        return Console.ReadLine();
    }

    static string InputName() {
        Console.Write("Name : ");

        return Console.ReadLine();
    }

    static string InputSurname() {
        Console.Write("Surname : ");

        return Console.ReadLine();
    }

    static int InputAge() {
        Console.Write("Age : ");
        int input = int.Parse(Console.ReadLine());

        return input;
    }

    static string InputCollegianID() {
        Console.Write("Collegian ID : ");

        return Console.ReadLine();
    }

    static string InputAllergy() {
        Console.Write("Allergy (Type 'none' if no allergy): ");

        return Console.ReadLine();
    }

    static int InputReligion() {
        Console.WriteLine("Choose your religion");
        Console.WriteLine(" 1. Buddhism");
        Console.WriteLine(" 2. Christianity");
        Console.WriteLine(" 3. Islam");
        Console.WriteLine(" 4. Other");
        Console.Write("Please input religion (Type in number): ");
        int input = int.Parse(Console.ReadLine());

        return input;
    }

    static int InputLevelOfEducation() {
        Console.WriteLine("Choose your level of education");
        Console.WriteLine(" 1. Grade 10");
        Console.WriteLine(" 2. Grade 11");
        Console.WriteLine(" 3. Grade 12");
        Console.Write("Please input level of education (Type in number): ");
        int input = int.Parse(Console.ReadLine());

        return input;
    }

    static string InputSchool() {
        Console.Write("School : ");

        return Console.ReadLine();
    }

    static int InputPosition() {
        Console.WriteLine("Choose your position");
        Console.WriteLine(" 1. Dean");
        Console.WriteLine(" 2. Head of Department");
        Console.WriteLine(" 3. Full-time Teacher");
        Console.Write("Please input position (Type in number): ");
        int input = int.Parse(Console.ReadLine());

        return input;
    }

    static int AskIfAdmin() {
        Console.WriteLine("Are you admin?");
        Console.WriteLine(" 1. Yes");
        Console.WriteLine(" 2. No");
        Console.Write("Please input answer (Type in number): ");
        int input = int.Parse(Console.ReadLine());

        return input;
    }

    static string InputEmail() {
        Console.Write("Email (If not admin, just press Enter): ");

        return Console.ReadLine();
    }

    static string InputPassword() {
        Console.Write("Password (If not admin, just press Enter): ");

        return Console.ReadLine();
    }

    static int AskIfCar() {
        Console.WriteLine("Do you bring car?");
        Console.WriteLine(" 1. Yes");
        Console.WriteLine(" 2. No");
        Console.Write("Please input answer (Type in number): ");
        int input = int.Parse(Console.ReadLine());

        return input;
    }

    static string InputCarLicensePlate() {
        Console.Write("Car License Plate (If no car, just press Enter): ");

        return Console.ReadLine();
    }

    //Show Stat

    static void ShowStat() {
        Console.Clear();
        Program.peopleList.CountStat();

        Console.Write("Press Any Button to go Back to MainMenu");
        Console.ReadLine();
        BackToBeforeLogin();
    }
    
    //Login

    static void Login() {
        Console.Clear();
        PrintLoginHeader();
        InputLoginEmail();
        InputLoginPassword();

        AfterLogin();
    }
    static void PrintLoginHeader() {
        Console.WriteLine("Admin Login");
        Console.WriteLine("************");
    }

    static string InputLoginEmail() {
        Console.Write("Email : ");

        return Console.ReadLine();
    }

    static string InputLoginPassword() {
        Console.Write("Password : ");

        return Console.ReadLine();
    }

    //After Login

    static void AfterLogin() {
        Console.Clear();

        PrintMenuAfterLogin();
        InputMenu2FromKeyboard();
    }

    static void PrintMenuAfterLogin() {
        Console.WriteLine("Welcome Admin to Idia Camp 2022 System");
        Console.WriteLine("**********************************************");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Show All Current Collegian");
        Console.WriteLine("3. Show All Student");
        Console.WriteLine("4. Show All Teacher");
        Console.WriteLine("5. Logout");
        Console.WriteLine("**********************************************");        
    }

    static void InputMenu2FromKeyboard() {
        Console.Write("Please input Menu (Type in number): ");
        Menu2 menu = (Menu2)(int.Parse(Console.ReadLine()));

        PresentMenu2(menu);
    }

    static void PresentMenu2(Menu2 menu) {
        switch (menu) {
            case Menu2.Register:
            RegisterMenu();
            break;
            case Menu2.Show_All_Current_Collegian:
            Console.Clear();
            Program.peopleList.FetchCollegianList();
            Console.Write("Press Any Button to go Back to MainMenu");
            Console.ReadLine();
            AfterLogin();
            break;
            case Menu2.Show_All_Student:
            Console.Clear();
            Program.peopleList.FetchStudentList();
            Console.Write("Press Any Button to go Back to MainMenu");
            Console.ReadLine();
            AfterLogin();
            break;
            case Menu2.Show_All_Teacher:
            Console.Clear();
            Program.peopleList.FetchTeacherList();
            Console.Write("Press Any Button to go Back to MainMenu");
            Console.ReadLine();
            AfterLogin();
            break;
            case Menu2.Logout:
            BackToBeforeLogin();
            break;
        default:
            break;
        }
    }
}