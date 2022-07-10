using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Collections;


namespace FridayTask
{
     public class Program
     {
          static void Main(string[] args)
          {
               List <Heroes> heroes = new List<Heroes>();
               Heroes shero1 = new Heroes(HeroIdGenerator(), "Iron Man", "Avengers");
               Heroes shero2 = new Heroes(HeroIdGenerator(), "Human Torch", "Fantastic Four");
               heroes.Add(shero1);
               heroes.Add(shero2);
               
               bool menu = true;
               while(menu)
               {
                    Console.Clear();
                    Console.WriteLine("\n Welcome to Marvel HQ!\n");
                    Console.WriteLine(" Choose an option: ");
                    Console.WriteLine(" 1) Show List of Characters! ");
                    Console.WriteLine(" 2) Show Info About a Specific Hero (ID)! ");
                    Console.WriteLine(" 3) Add a new Hero! ");
                    Console.WriteLine(" 4) Edit a Hero (ID)! ");
                    Console.WriteLine(" 5) Delete a Hero (ID)! ");
                    Console.WriteLine(" 6) Exit");
                    Console.Write("\r\n Select an option: ");
                    
                    int key = Convert.ToInt32(Console.ReadLine());
                    switch (key)
                    {
                         case 1:
                              {
                                   Console.Clear();
                                   Console.WriteLine("\n Your Heroes: \n");
                                   foreach (Heroes superhero in heroes)
                                   {
                                        Console.WriteLine(" ID: " + superhero.heroID + " " + superhero.heroName + " - " + superhero.heroFaction);
                                   }
                                   Console.Write("\n Press Enter to Return... ");
                                   Console.ReadLine();
                                   break;
                              }
                         case 2:
                              {
                                   Console.Clear();
                                   Console.Write("\n Select Hero by ID: ");
                                   int hero_ID = Convert.ToInt32(Console.ReadLine());
                                   var Item = heroes.Single(h => h.heroID == hero_ID);
                                   Console.WriteLine("\n " + Item.heroName + " - " + Item.heroFaction);
                                   Console.Write("\n Press Enter to Return... ");
                                   Console.ReadLine();
                                   break;
                              }
                         case 3:
                              {
                                   Console.Clear();
                                   Console.Write("\n Enter Hero's name: ");
                                   string heroName = Console.ReadLine();
                                   Console.Write("\n Enter Hero's fraction: ");
                                   string heroFaction = Console.ReadLine();
                                   var shero = new Heroes(HeroIdGenerator(), heroName, heroFaction);
                                   heroes.Add(shero);
                                   Console.Write("\n Press Enter to Return... ");
                                   Console.ReadLine();
                                   break;
                              }
                        case 4:
                              {
                                   Console.Clear();
                                   Console.Write("\n Enter Hero ID: ");
                                   int hero_ID = Convert.ToInt32(Console.ReadLine());
                                   var heroEdit = heroes.Single(h => h.heroID == hero_ID);
                                   if (heroes.Contains(heroEdit))
                                   {
                                        Console.WriteLine(" Hero Found!");
                                   }
                                   Console.WriteLine("\n Current Name: " + heroEdit.heroName + "\n Current Alliance: " + heroEdit.heroFaction);               
                                   Console.WriteLine("\n What would you like to edit? \n Press 1 - Name\n Press 2 - Alliance");
                                   Console.Write("\n Press: ");
                                   int key1 = Convert.ToInt32(Console.ReadLine()); 
                                   switch(key1)
                                   {
                                        case 1:
                                             {
                                                  Console.Write(" Enter New Hero Name: ");
                                                  string NewHeroName = Console.ReadLine();
                                                  string str = new string(heroEdit.heroName);
                                                  Console.WriteLine("\n Initial String: " + heroEdit.heroName);
                                                  //inlocuim numele
                                                  str = str.Replace(heroEdit.heroName, NewHeroName);
                                                  Console.WriteLine(" Name after Substitution: " + str);
                                                  Console.WriteLine(" ID: " + hero_ID + "\n Name: " + str + "\n Alliance: " + heroEdit.heroFaction);
                                                  heroEdit.heroName = str;
                                                  Console.Write("\n Press Enter to Return... ");
                                                  Console.ReadLine();
                                                  break;
                                             }
                                        case 2:
                                             {
                                                  Console.Write(" Enter New Hero Alliance: ");
                                                  string NewHeroAlliance = Console.ReadLine();
                                                  string str = new string(heroEdit.heroFaction);
                                                  Console.WriteLine("\n Initial String: " + heroEdit.heroFaction);
                                                  //inlocuim alianta
                                                  str = str.Replace(heroEdit.heroFaction, NewHeroAlliance);
                                                  Console.WriteLine(" Name after Substitution: " + str + "\n");
                                                  Console.WriteLine(" ID: " + hero_ID + "\n Name: " + heroEdit.heroName + "\n Alliance: " + str);
                                                  heroEdit.heroFaction = str; 
                                                  Console.Write("\n Press Enter to Return... ");
                                                  Console.ReadLine();
                                                  break;
                                             }
                                   }
                                   break;
                              }
                         case 5:
                              {
                                   Console.Clear();
                                   Console.Write("\n Enter Hero's ID: ");
                                   int hero_ID = Convert.ToInt32(Console.ReadLine());
                                   var Item = heroes.Single(item => item.heroID == hero_ID);
                                   heroes.Remove(Item);
                                   Console.WriteLine("\n Hero Successfully Deleted! ");
                                   Console.Write("\n Press Enter to Return... ");
                                   Console.ReadLine();
                                   break;
                              }
                         case 6:     
                              default:
                              menu = false;
                              break;
                    }
               }
          }

          public static int HeroIdGenerator()
          {
               Random rnd = new Random();
               return rnd.Next(1, 100); 
          }
     }
}
   







