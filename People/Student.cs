public class Student: Person{
    private int levelOfEducation;
    private string school;

    public Student(string name_prefix, string name, string surname, int age, int levelOfEducation, string allergy, int religion, string school)
    : base(name_prefix, name, surname, age, allergy, religion) {
        this.levelOfEducation = levelOfEducation;
        this.school = school;
    }

    public int GetLevelOfEducation() {
        return this.levelOfEducation;
    }

    public string GetSchool() {
        return this.school;
    }
}