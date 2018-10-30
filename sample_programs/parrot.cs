// Dr. Mohan
// Lab 5 demonstration program
//
// See files "parrot.cs" and "lab5demo.cs" for the
// other parts of this program.

using System;
namespace ParrotNS
{
   // A Parrot has a name and always says "Awwwk!"
   class Parrot {
      private string name;
   
      // Constructor:
      public Parrot(string n) {
         name = n;
      }
   
      public string getName() { return name; }
   
      public string speak() { return "Awwwk!"; }
   }
}
