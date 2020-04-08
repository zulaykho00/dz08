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

            


            
        }
    }
}