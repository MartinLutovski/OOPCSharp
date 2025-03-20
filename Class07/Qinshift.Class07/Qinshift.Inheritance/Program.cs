using Qinshift.Inheritance.models;
using Qinshift.Inheritance.Models;
using Qinshift.Library.Services;

Animal animal = new Animal();
Dog blacky = new Dog("Blacky", "dog", "white", "doberman");
blacky.Speak();

Cat mica = new Cat("Mica", "cat", "black", true);
mica.Speak();

int userInput = int.Parse(Console.ReadLine());
MonthService monthService = new MonthService();
monthService.GetMonthOutOfNumber(userInput);