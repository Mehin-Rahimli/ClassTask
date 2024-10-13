namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Mehin","Rahimli","BP217",98,true);
            student.CheckGraduation();
            student.GetInfo();
            student.GetDiplomaDegree();
           
        }
    }
}
