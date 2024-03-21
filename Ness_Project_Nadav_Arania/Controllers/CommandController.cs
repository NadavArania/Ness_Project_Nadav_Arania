using Ness_Project_Nadav_Arania.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ness_Project_Nadav_Arania.Controllers
{
    public class CommandController : ICommands
    {
        public List<string> list = new List<string>();
        public List<string> options = new List<string>() { "Add", "Remove", "Update", "Exit" };
        public bool keepGoing = true;
        public string choice;
        public bool approved = false;
        public string assignment;

        public void AddAssignment()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Write assignment that you want to add." + "\n");
                assignment = Console.ReadLine();
                if (assignment is not null)
                {
                    list.Add(assignment);
                }
                else
                {
                    Console.WriteLine("\n" + "Couldn't add assignment, Please try again." + "\n");
                }
                approved = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveAssignment()
        {
            try
            {
                Console.Clear();
                if (list.Any())
                {
                    list.ForEach(option => Console.WriteLine(list.IndexOf(option) + "." + option.ToString()));
                    Console.WriteLine("Choose assignment index that you want to remove" + "\n");
                    assignment = Console.ReadLine();
                    int convertedRemoveAssignment = Convert.ToInt32(assignment);
                    if (list.Any(x => x == list[convertedRemoveAssignment]))
                    {
                        string assignmentToRemove = list[convertedRemoveAssignment];
                        list.Remove(assignmentToRemove);
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Couldn't remove assignment, Please try again." + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "There are no assignment registered yet." + "\n");
                }
                approved = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateAssignment()
        {
            try
            {
                Console.Clear();
                if (list.Any())
                {
                    list.ForEach(option => Console.WriteLine(list.IndexOf(option) + "." + option.ToString()));
                    Console.WriteLine("Choose assignment index that you want to update" + "\n");
                    assignment = Console.ReadLine();
                    int convertedUpdateAssignment = Convert.ToInt32(assignment);
                    if (list.Any(x => x == list[convertedUpdateAssignment]))
                    {
                        Console.WriteLine("\n" + "Write assignment." + "\n");
                        choice = Console.ReadLine();
                        if (choice is not null)
                        {
                            list[convertedUpdateAssignment] = choice;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Couldn't update assignment, Please try again." + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "There are no assignment registered yet." + "\n");
                }
                approved = false;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void Exit()
        {
            Console.Clear();
            Environment.Exit(0);
            approved = false;
        }
    }
}
