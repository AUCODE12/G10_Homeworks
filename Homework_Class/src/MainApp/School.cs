using System.Diagnostics;

namespace MainApp;

internal class School
{
    // Maktab nomi
    public string Name { get; set; }

    // Maktab joylashuvi (shahar, mamlakat)
    public string Location { get; set; }

    // Maktab tashkil etilgan yili
    public int EstablishedYear { get; set; }

    // Talabalar soni
    public int StudentCount { get; set; }

    // Maktab direktori ismi
    public string Principal { get; set; }

    // Maktab turi (masalan, davlat, xususiy)
    public string Type { get; set; }

    // Sinflar soni
    public int ClassCount { get; set; }

    // O‘qitiladigan fanlar soni
    public int SubjectCount { get; set; }

    // O‘qituvchilar soni
    public int TeacherCount { get; set; }

    public void DisplayInfo()
    {
        string result = $"School -> Name: {Name}, Location: {Location}, EstablishedYear: {EstablishedYear}, StudentCount: {StudentCount}, Principal: {Principal}, Type: {Type}, ClassCount: {ClassCount}, SubjectCount: {SubjectCount}, TeacherCount: {TeacherCount}";
        Console.WriteLine(result);
    }
}
