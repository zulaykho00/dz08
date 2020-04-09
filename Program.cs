using System;

namespace dz08
{
    class Converter 
    { double UsdTjs, EurTjs, RubTjs, TjsUsd,TjsEur,TjsRub,Tjs,usd,eur,rub;
         public  Converter (double usd ,double eur, double rub)
      {
          this.usd=usd;
          this.eur=eur;
          this.rub=rub;
      }
      public void ConToTjs()
      {
          UsdTjs=usd*10.22;
          EurTjs=eur*11.14;
          RubTjs=rub*0.14;
          Console.WriteLine($"UsdTjs={UsdTjs}\nEurTjs={EurTjs}\nRubTjs={RubTjs}\n");
      }
      public void ConFromTjs()
      {
          Console.Write("Tjs=");
          Tjs=Convert.ToDouble(Console.ReadLine());
          TjsUsd=Tjs/10.22;
          TjsEur=Tjs/11.14;
          TjsRub=Tjs/0.14;
          Console.WriteLine($"TjsUsd={TjsUsd}\nTjsEur={TjsEur}\n TjsRub={ TjsRub}");
      }
    }
    class Employee
    {string [] lastname,name;
      public string [] LastName{get;set;}
      public string [] Name{get;set;}
      public string [] Position{get;set;}
       public Employee(string [] lastname,string [] name)
        {
         this.lastname=lastname;
         this.name=name;
        }
        
        public void Salary(int i)
        {
            double [] a=new double []{1000,2000,4000};
            
           // for(int i=0;i<3;i++)
            //{
                Console.Write("оклад:");
                Console.WriteLine(a[i]);
                a[i]=a[i]-a[i]*0.96;
                Console.Write("налоговый сбор:");
                Console.WriteLine(a[i]);
           // }
        }

         
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZADANIE#2");
            double eur,usd,rub;
             Console.Write("USD=");
             usd=Convert.ToDouble(Console.ReadLine());
             Console.Write("EUR=");
             eur=Convert.ToDouble(Console.ReadLine());
             Console.Write("RUB=");
             rub=Convert.ToDouble(Console.ReadLine());
              Converter Con=new Converter(usd,eur,rub);
             Con.ConToTjs();
             Con.ConFromTjs();
             Console.WriteLine("ZADANIE#3");
             
             
             string [] LastName=new string[]{"Tomy","Jerryy","Maxy"};
             string [] Name=new string[]{"Tom","Jerry","Max"};
             string [] Position=new string[]{"Cat","Mouse","Dog"};
             Employee Emp= new Employee(LastName,Name);
             Console.Write("введите число [0-2]: ");
             int i=Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine($"LastName:{LastName[i]}");
                 Console.WriteLine($"Name:{Name[i]}");
                 Console.WriteLine($"Position:{Position[i]}");
                 Emp.Salary(i);
             
             

          


            
        }
    }
}