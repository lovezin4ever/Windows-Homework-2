public class Student : IComparable
{
    public double mygrade;
    public string mysubject, myID;
    public Student() { }
    public Student(double grade, string subject, string id)
    {
        mygrade = grade;
        mysubject = subject;
        myID = id;
    }
    int IComparable.CompareTo(Object obj)
    {
        if (obj is Student)
        {
            Student student = (Student)obj;
            if (this.mygrade > student.mygrade) return 1;
            else if (this.mygrade < student.mygrade) return -1;
            else return 0;
        }
        throw new ArgumentException("所比较的对象并非Student类别");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Student[] students = new Student[5];
        students[0] = new Student(50.0, "windows程序设计", "001");
        students[1] = new Student(90.0, "windows程序设计", "002");
        students[2] = new Student(100.0, "windows程序设计", "003");
        students[3] = new Student(70.0, "windows程序设计", "004");
        students[4] = new Student(80.0, "windows程序设计", "005");
        Array.Sort(students);
        Console.WriteLine("依次由低到高输出成绩:");
        Console.WriteLine("#########################################");
        foreach (Student student in students)
        {
            Console.WriteLine("成绩:{0}  课程:{1}  学号: {2}", student.mygrade, student.mysubject, student.myID);
        }
        Console.WriteLine("#########################################");
    }
}