public class Collegian: Person{
    private string Collegian_ID;
    private int IfAdmin;
    private string Email;
    private string Password;

    public Collegian(string name_prefix, string name, string surname, int age, string Collegian_ID, string allergy, int religion, int IfAdmin, string Email, string Password)
    : base(name_prefix, name, surname, age, allergy, religion) {
        this.Collegian_ID = Collegian_ID;
        this.IfAdmin = IfAdmin;
        this.Email = Email;
        this.Password = Password;
    }

    public string GetCollegianID() {
        return this.Collegian_ID;
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