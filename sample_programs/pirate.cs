// Dr. Mohan
// Lab 5 demonstration program
//
// See files "parrot.cs" and "lab5demo.cs" for the
// other parts of this program.

using System;

namespace PirateNS
{
   // A Pirate has a name and always says "Arrrr!"
   class Pirate {
      private string name;
   
      // Constructor:
      public Pirate(string n) {
         name = n;
      }
   
      public string getName() { return name; }
   
      public string speak() { return "Arrrr!"; }
   }
}
