public class Person {
    private string name_prefix;
    private string name;
    private string surname;
    private int age;
    private string allergy;
    private int religion;

    public Person(string name_prefix, string name, string surname, int age, string allergy, int religion) {
        this.name_prefix = name_prefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
    }

    public string GetName_prefix() {
        return this.name_prefix;
    }
    public string GetName() {
        return this.name;
    }
    public string GetSurname() {
        return this.surname;
    }
    public int GetAge() {
        return this.age;
    }
    public string GetAllergy() {
        return this.allergy;
    }
    public int GetReligion() {
        return this.religion;
    }
}