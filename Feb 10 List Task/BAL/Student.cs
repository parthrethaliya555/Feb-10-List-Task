using Feb_10_List_Task.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Feb_10_List_Task.BAL
{
    public  class Student
    {

        public List<StudentModel4> GetStudentList()
        {
            List<StudentModel4> lstStudent = new();
            lstStudent.Add(new StudentModel4()
            {
                Id = 1,
                Name = "Jaypal",
                DOB = DateTime.Now.AddYears(-25),
                Gender = "M",
                RollNo = "RL_1",
                Std = 12,
                SurName = "Vasveliya"
            });
            lstStudent.Add(new StudentModel4()
            {
                Id = 2,
                Name = "Milan",
                DOB = DateTime.Now.AddYears(-22),
                Gender = "M",
                RollNo = "RL_2",
                Std = 12,
                SurName = "Gandhi"
            });
            lstStudent.Add(new StudentModel4()
            {
                Id = 3,
                Name = "Khushi",
                DOB = DateTime.Now.AddYears(-20),
                Gender = "F",
                RollNo = "RL_3",
                Std = 12,
                SurName = "Mehta"
            });

            return lstStudent;
        }
        public List<string> GetStudentBasedOnAge(int age) //5
        {
            List<StudentModel4> lstStudent = GetStudentList(); //3
            int year = DateTime.Now.AddYears(-age).Year; //2020
            List<StudentModel4> flterList = new(); //0
            foreach (StudentModel4 student in lstStudent)
            {
                if (year > student.DOB.Year)//2020 < 2000 
                {
                    flterList.Add(student);
                }
            }
            return flterList.Select(x => x.Name).ToList();
        }
        public List <string> GetAllNameCapital()//1
        {
            List<StudentModel4> lstStudent = GetStudentList();
            List<string> strings = new List<string>();

            foreach (StudentModel4 student in lstStudent)
            {
                string student3 = student.Name.ToUpper();
                strings.Add(student3);
            }
            return strings;
           }   
        public List <string> GetFullName()//2
        {
            List<StudentModel4> lstStudent = GetStudentList();
            List <string> lstFullNames = new();    
            foreach (StudentModel4 student in lstStudent)
            {
                string Fullname = student.Name + " " + student.SurName;
                lstFullNames.Add(Fullname);
            }
            return lstFullNames;

        }

        public List<StudentModel4> AddNewStudent()//3
        {
            List<StudentModel4> lstStudent = GetStudentList();
            lstStudent.Add(new StudentModel4() { Id = 4, Name = "Dhaval", SurName = "Yadav", DOB = DateTime.Now.AddYears(-24), Gender = "M", Std = 12, RollNo = "RL_4" });
            return lstStudent;
        }

        public List<string> StartWith(string name) //4
        { 
            List <StudentModel4>lststudent = GetStudentList();
            List<string> lststartwith= new();

            foreach (StudentModel4 student in lststudent)
            {
                if (student.Name.ToLower().StartsWith(name.ToLower()))
                {
                    lststartwith.Add(student.Name);
                }

            }
            return lststartwith;
        }

        public List <string> GetStudentinRange (int min,int max)//5
        {
            List<StudentModel4> lststudent2 = GetStudentList();
            List<string> lstinRange = new();

            foreach (StudentModel4 student in lststudent2) 
            { 
                int age = DateTime.Now.Year - student.DOB.Year;
                if (age >= min && age <= max)
                {
                    lstinRange.Add(student.Name);

                }
            }
            return lstinRange;
        }

        public List<string>ShowDOB()//6
        {
            List<StudentModel4> lststudent2 = GetStudentList();
            List<string> lstshow = new();

            foreach (StudentModel4 student in lststudent2)
            {
              string date = student.DOB.ToString("dd-MMMM-yyyy");
                lstshow.Add(date);
            }
            return lstshow;
        }

        public List<string> ChangeSurname(string From, string To)//7
        {
            List<StudentModel4> lststudent2 = GetStudentList();
            List<string> lstchange = new();

            foreach (StudentModel4 student in lststudent2)
            {

                if (From == student.SurName) 
                {
                    lstchange.Add(student.Name + " " +student.SurName);
                }
               if (From== student.SurName)
                  {
                    student.SurName = To;

                    lstchange.Add( student.Name+ " " +student.SurName);
                       
                        
               }
                

            }
            return lstchange;
        }

        public List<string> GetUpdatedStudentlist()//8
        {
            List<StudentModel4> list2 = GetStudentList();
            List<string> strings = new List<string>();
            foreach (StudentModel4 student in list2)
            {
                string rollno = student.RollNo.Replace("RL", "#");

                strings.Add(rollno);
            }

            return strings;
        }

    }
}
