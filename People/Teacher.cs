public class Teacher: Person{
    private int position;
    private int IfCar;
    private string CarLicensePlate;
    private int IfAdmin;
    private string Email;
    private string Password;

    public Teacher(string name_prefix, string name, string surname, int age, int position, string allergy, int religion, int IfCar, string CarLicensePlate, int IfAdmin, string Email, string Password)
    : base(name_prefix, name, surname, age, allergy, religion) {
        this.position = position;
        this.IfCar = IfCar;
        this.CarLicensePlate = CarLicensePlate;
        this.IfAdmin = IfAdmin;
        this.Email = Email;
        this.Password = Password;
    }

    public int GetPosition() {
        return this.position;
    }

    public int GetIfCar() {
        return this.IfCar;
    }

    public string GetCarLicensePlate() {
        return this.CarLicensePlate;
    }

    public int GetIfAdmin() {
        return this.IfAdmin;
    }

    public string GetEmail() {
        return this.Email;
    }

    public string GetPassword() {
        return this.Password;
    }
}