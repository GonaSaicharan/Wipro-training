using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        StudentMakrs myStudents=new StudentMakrs();
        myStudents[0]=90;
        myStudents[1]=100;
        myStudents[2]=200;
        myStudents[3]=160;
        
        Console.WriteLine("Students marks are:");
        Console.WriteLine(myStudents[0]);
        Console.WriteLine(myStudents[1]);
        Console.WriteLine(myStudents[2]);
        Console.WriteLine(myStudents[3]); 
    }
}
class StudentMakrs
{
    public string StudentName{get;set;}
    private int[] marks = new int[4];
    public int this[int index]
    {
        get
        {
            return marks[index];
        }
        set
        {
            marks[index] = value;
        }
    }
}