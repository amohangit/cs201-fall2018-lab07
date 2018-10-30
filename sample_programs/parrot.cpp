// Dr. Mohan
// Demonstration program for lab 8. This program is used in
// conjunction with the following files:
//       lab5demo.cpp
//       pirate.h
//       pirate.cpp
//       parrot.h

#include <string>
#include "parrot.h"

using namespace std;

Parrot::Parrot(string n) { Parrot::name = n; }

string Parrot::getName() { return Parrot::name; }

string Parrot::speak() { return "Awwwk!"; }
