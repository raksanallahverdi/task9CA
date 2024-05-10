

using System;  
using System.Drawing;
using System.IO.Compression;
using System.Net.Sockets;

namespace Test
{
    public static class Program
    {
        
    
    public static void Main(string [] args)
    {
        // task1
        // Animal dog=new Animal("Cherry","Puppy","Golden",1);
        // dog.GetDetails();

        // task2
        // Building FlameTowers=new Building("FlameTower",2000,90);
        // FlameTowers.address="Azerbaijan";
        // FlameTowers.GetDetails();

        // task3
        // Student student1= new Student("Raksana","Allahverdiyeva",20,new int[] {100,100,90,80},new int[] {100,100,100,80} ,new int[] {100,100,100,100},90,new bool[] {true,false,true,true,true,true}) ;
        // student1.CheckDegree();

        // task4
        // Gun dp=new Gun("dp",12,10,500,"assaultg");
        // dp.FinalDetails();
        // dp.Fire();
        // dp.FinalDetails();
        // dp.Reload();
        // dp.FinalDetails();

        // task5
        // Console.WriteLine("Enter numbers");
        // int number1=Convert.ToInt32(Console.ReadLine());
        // int number2=Convert.ToInt32(Console.ReadLine());
        // mark:
        // Console.WriteLine("Enter operator");
        // string operator11=Console.ReadLine();
        // Calculator numbers=new Calculator(number1,number2,operator11);
        // if (operator11=="+"){
        //      numbers.Add();
        // }
        // else if (operator11=="-"){
        //      numbers.Substract();
        // }
        // else if (operator11=="*"){
        //      numbers.Multiply();
        // }
        // else if (operator11=="/"){
        //      numbers.Divide();
        // }
        
        // else{
        //     Console.WriteLine("Wrong Operator entered");
        //     goto mark;
        // }
        
        

    }
    }
// task1
    public class Animal{
        
        public string name;
        public string breed;
        public string color;
        public int age;
        public Animal(string name,string breed,string color,int age){
            this.name=name;
            this.breed=breed;
            this.color=color;
            this.age=age;

        }

        public void GetDetails(){
            Console.WriteLine($"{name} is {age} years old and its breed is {breed} and its color is {color}"); 
        }
    }

// task2
    public class Building{
        public string name;
        public int height;
        public int area;
        public string address;

        public Building(string name,int height,int area){
            this.name=name;
            this.height=height;
            this.area=area;

        }
        public int GetVolume(){
            return height*area;
        }
        public void GetDetails(){
            int resultVolume=GetVolume();
            Console.WriteLine($"This building is {name}, its height is {height},its area is {area},its volume is {resultVolume} and address {address}");
            
        }
    }

// task3
    public class Student{
        public string name;
        public string surname;
        public int age;
        int[] homeworkGrades;
        int[] projectGrades;
        int[] quizGrades;
        int finalGrade;
        bool[] continuity;

        public Student(string name,string surname,int age,int[] homeworkGrades,int[] projectGrades,int[] quizGrades,int finalGrade,bool[] continuity){
                this.name=name;
                this.surname=surname;
                this.age=age;
                this.homeworkGrades=homeworkGrades;
                this.projectGrades=projectGrades;
                this.quizGrades=quizGrades;
                this.finalGrade=finalGrade;
                this.continuity=continuity;
        }

        public int GetContinuityGrade(bool[] continuity){
            int attendedCount=0;
            foreach(var isAttended in continuity){
                if(isAttended){
                    attendedCount++;
                }
            }
            return attendedCount *100 /continuity.Length;
        }

        public int GetAverageGrade(int[] grades){
            int totalgGrade=0;
            foreach (var grade in grades)
            {
                totalgGrade+=grade;
            }
            return totalgGrade/grades.Length;
        }

        public int getResult(){

            int totalhomeworkGrade=GetAverageGrade(homeworkGrades);
            int totalprojectGrade=GetAverageGrade(projectGrades);
            int totalquizGrade=GetAverageGrade(quizGrades);
            int totalContinuity=GetContinuityGrade(continuity);

            return (totalhomeworkGrade*20)/100+ (totalprojectGrade*20)/100+
            (totalquizGrade*20)/100+(totalContinuity*10)/100+(finalGrade*30)/100;

    
        }
        
        public void CheckDegree(){
            int studentResult=getResult();
            if (studentResult>=95){
                Console.WriteLine($" {studentResult} - High Honour");
            }
            else if (studentResult>=85){
                Console.WriteLine($" {studentResult} -  Honour");
            }
            else if (studentResult>=65){
                Console.WriteLine($" {studentResult} -  Normal");
            }
            else{
                Console.WriteLine($" {studentResult} -  Fail");

            }
        }


    }
}

// task4
    public class Gun{
        public string name;
        public int maxCapacity;
        public int currentBullet;
        public int totalBullet;
        public string type;
        

        public Gun(string name,int maxCapacity,int currentBullet,int totalBullet,string type){
            this.name=name;
            this.maxCapacity=maxCapacity;
            this.currentBullet=currentBullet;
            this.totalBullet=totalBullet;
            this.type=type;
            if (currentBullet>maxCapacity){
                Console.WriteLine("currentBullet maxCapacity-den boyuk ola bilmez! ");
            }
            if (!type.Equals("assault", StringComparison.OrdinalIgnoreCase) && 
    !type.Equals("sniper", StringComparison.OrdinalIgnoreCase)){
        Console.WriteLine("Wrong Gun Type Entered !!! ");
    }
            
        }
        public void Fire(){
            if (type=="assault"){
                 currentBullet=0;
            }
            else{
                 currentBullet-=1;
            }
        }
        public void Reload(){
            int temp=currentBullet;
            currentBullet=maxCapacity;
            totalBullet=totalBullet-(maxCapacity-temp);
            
        }
        public void FinalDetails(){
            Console.WriteLine($"{name},{maxCapacity},{currentBullet},{totalBullet},{type}");
        }



    }

// task5

public class Calculator{
    public int number1;
    public int number2;
    public string method;

    public Calculator(int number1,int number2,string method){

        this.number1=number1;
        this.number2=number2;
        this.method=method;
    }
    public void Add(){
        Console.WriteLine(number1+number2);
    }
    public void Substract(){
        Console.WriteLine(number1-number2);
    }
    public void Multiply(){
        Console.WriteLine(number1*number2);
    }
    public void Divide(){
        Console.WriteLine(number1/number2);
    }

    



}