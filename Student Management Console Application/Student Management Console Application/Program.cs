using System.Text;
using Student_Management_Console_Application;

Console.OutputEncoding = Encoding.UTF8;

Student[] students = new Student[0];

int nextId = 1;

bool running = true;

while (running)
{
    Console.WriteLine("\n--- Student Management ---");
    Console.WriteLine("1. Yeni tələbə əlavə et");
    Console.WriteLine("2. Tələbə sil");
    Console.WriteLine("3. Tələbəyə qiymət əlavə et");
    Console.WriteLine("4. Bütün tələbələri göstər");
    Console.WriteLine("5. Çıxış");
    Console.Write("Seçiminizi daxil edin: ");
    string chosenOption = Console.ReadLine();

    switch (chosenOption)
    {
        case "1":

            AddStudent(ref students, ref nextId);
            break;
        case "2":
            break;
        case "3":
            AddGrade(students);
            break;
        case "4":
            GetAll(students);
           
            break;
        case "5":

            running = false;
            Console.WriteLine("Proqram bitdi");
            break;
        default:
            Console.WriteLine("Düzgün seçim et (1-5)");
            break;

    }
}

static void AddStudent(ref Student[] students, ref int nextId)
{
    Console.Write("Tələbənin adını daxil edin: ");
    string name = Console.ReadLine();

    Console.Write("Tələbənin soyadını daxil edin: ");
    string surname = Console.ReadLine();

    Student newStudent = new Student(nextId, name, surname);
    nextId++;

    
    Student[] newStudents = new Student[students.Length + 1];
    for (int i = 0; i < students.Length; i++)
    {
        newStudents[i] = students[i];
    }
    newStudents[students.Length] = newStudent;
    students = newStudents;

    Console.WriteLine("Yeni tələbə əlavə olundu!");
}

static void AddGrade(Student[] students)
{
    Console.Write("Tələbənin ID-sini daxil edin: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Student student = null;

    for (int i = 0; i < students.Length; i++)
    {
        if (students[i].Id == id)
        {
            student = students[i];
            break;
        }
    }

    if (student == null)
    {
        Console.WriteLine("Bu ID-li tələbə tapılmadı!");
        return;
    }

    Console.Write("Yeni qiyməti daxil edin: ");
    int grade = Convert.ToInt32(Console.ReadLine());

    
    int[] newGrades = new int[student.Grades.Length + 1];
    for (int i = 0; i < student.Grades.Length; i++)
    {
        newGrades[i] = student.Grades[i];
    }
    newGrades[newGrades.Length - 1] = grade;

    student.Grades = newGrades;

    Console.WriteLine("Qiymət əlavə olundu!");
}

static void GetAll(Student[] students)
{
    if (students.Length == 0)
    {
        Console.WriteLine("Telebe yoxdur!");
        return;
    }

    Console.WriteLine("Telebeler");
    Console.WriteLine("----------------------------------");

    foreach (var a in students)
    {
        a.ShowInfo();

    }
}