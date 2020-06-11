using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      
       
       Console.WriteLine();
       
       Console.WriteLine("==== Stats Senjata ====");
       
       Console.WriteLine();
       
       Stats stats;
       
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
       
   
   public abstract class Stats {
     public abstract void name();
     public abstract void accurate();
     public abstract void damage();
   }
   
   public class smg : Stats {
     public override void name() {
       Console.WriteLine("Name  : OA-93 ");
     }
     
     public override void accurate() {
       Console.WriteLine("Accurate : 59 ");
     }
     
     public override void damage() {
       Console.WriteLine("Damage : 22 ");
     }
   }
   
   public class rifle : Stats {
     public override void name() {
       Console.WriteLine("Name : SC-2010 ");
     }
     
     public override void accurate() {
       Console.WriteLine("Accurate : 66 ");
     }
     
     public override void damage() {
       Console.WriteLine("Damage : 24 ");
     }
   }

   public class sniper : Stats {
     public override void name() {
       Console.WriteLine("Name : Cheytac M200 ");
     }
     
     public override void accurate() {
       Console.WriteLine("Accurate : 87 ");
     }
     
     public override void damage() {
       Console.WriteLine("Damage : 95 ");
     }
   }
 
   
   
   } 
   
 }
