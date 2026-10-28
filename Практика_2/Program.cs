using System;

Student student1 = new Student("Петренко", "Иван", "Ванько", "20.01.1999", "Майкоп", "+79184561101", "petrenko@mail.ru", 2, "ИП-23", 10203);
Student student2 = new Student("Петренков", "Иванко", "Ваньковьски", "20.01.1997", "Майкопск", "+79184561102", "petrenkov@mail.ru", 1, "ИП-13", 10302);

Console.WriteLine(student1);
Console.WriteLine(student1.sravneniePoZachetke(student2));
public class Student
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Otchestvo { get; set; }
    public string Birthdate { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int Kurs {  get; set; }
    public string Group { get; set; }
    public int NomerZachetki { get; }

    public Student (){
        Surname = "";
        Name = "";
        Otchestvo = "";
        Birthdate = "";
        Address = "";
        Phone = "";
        Email = "";
        Kurs = 1;
        Group = "";
        NomerZachetki = 0;
    }
    public Student(string Surname, 
        string Name, 
        string Otchestvo, 
        string Birthdate, 
        string Address, 
        string Phone, 
        string Email, 
        int Kurs, 
        string Group, 
        int NomerZachetki)
    {
        this.Surname = Surname;
        this.Name = Name;
        this.Otchestvo = Otchestvo;
        this.Birthdate = Birthdate;
        this.Address = Address;
        this.Phone = Phone;
        this.Email = Email;
        this.Kurs = Kurs;
        this.Group = Group;
        this.NomerZachetki = NomerZachetki;
    }

    public override string ToString()
    {
        return $"ФИО : {Surname} {Name} {Otchestvo}, " +
            $"Дата рождения: {Birthdate}, " +
            $"Адрес: {Address}, " +
            $"Номер телефона: {Phone}, " +
            $"почта: {Email}, " +
            $"курс: {Kurs}, группа: {Group}, номер зачетки: {NomerZachetki}"; 
    }

    public bool sravneniePoZachetke(Student other)
    {
        return NomerZachetki == other.NomerZachetki;
    }


    
}


