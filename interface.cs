using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       Console.WriteLine();

       Console.WriteLine("==== Stats Senjata ====");

       Console.WriteLine();

       IStats stats;

       stats = new smg();
       stats.name();
       stats.accurate();
       stats.damage();

       Console.WriteLine();

       stats = new rifle();
       stats.name();
       stats.accurate();
       stats.damage();

       Console.WriteLine();

       stats = new sniper();
       stats.name();
       stats.accurate();
       stats.damage();
     }


     public interface IStats{
     void name();
     void accurate();
     void damage();
   }

  public class smg : IStats {
     public void name() {
       Console.WriteLine("Name : Kriss SV ");
     }

     public void accurate() {
       Console.WriteLine("Accurate : 62 ");
     }
     public void damage() {
       Console.WriteLine("Damage : 21");
     }

   } 


   public class rifle : IStats {
     public void name() {
       Console.WriteLine("Name : AUG A3");
     }
     public void accurate() {
       Console.WriteLine("Accurate : 59 ");
     }
     public void damage() {
       Console.WriteLine("Damage : 22");
     }

   }

   public class sniper : IStats {
     public void name() {
       Console.WriteLine("Name : Tactilite T2");
     }
     public void accurate() {
       Console.WriteLine("Accurate : 85 ");
     }
     public void damage() {
       Console.WriteLine("Damage : 97");
     }

   }

 }
}