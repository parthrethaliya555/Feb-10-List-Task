// See https://aka.ms/new-console-template for more information
using Feb_10_List_Task.BAL;
using Feb_10_List_Task.Model;

Console.WriteLine("Hello, World!");

Student objStudent = new();



List<string> lstStudentName2 = objStudent.ChangeSurname("Mehta","Patel");
foreach (string student in lstStudentName2)
{
    Console.WriteLine(student);
}



