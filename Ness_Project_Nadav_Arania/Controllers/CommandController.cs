using Ness_Project_Nadav_Arania.Contracts;
using Ness_Project_Nadav_Arania.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ness_Project_Nadav_Arania.Controllers
{
    public class CommandController : ICommands
    {
        public List<Assignment> list = new List<Assignment>();
        public List<string> options = new List<string>() { "Add", "Remove", "Update", "Exit" };
        public bool keepGoing = true;
        public string choice;
        public bool approved = false;
        public string assignment;
        public DateTime assignmentDate;
        public string status = "Ongoing";
        
        //Add assignment to app
        public void AddAssignment()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Write assignment that you want to add." + "\n");
                assignment = Console.ReadLine();
                if (assignment is not null)
                {
                    Assignment newAssignment = new Assignment(assignment,DateTime.Now,status);
                    list.Add(newAssignment);
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

        //Remove assignment from app
        public void RemoveAssignment()
        {
            try
            {
                Console.Clear();
                if (list.Any())
                {
                    list.ForEach(option => Console.WriteLine(list.IndexOf(option) + "." + option.AssignmentTitle));
                    Console.WriteLine("\n" + "Choose assignment index that you want to remove" + "\n");
                    assignment = Console.ReadLine();
                    int convertedRemoveAssignment = Convert.ToInt32(assignment);
                    if (list.Any(x => x == list[convertedRemoveAssignment]))
                    {
                        Assignment assignmentToRemove = list[convertedRemoveAssignment];
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

        //Update assignment in app
        public void UpdateAssignment()
        {
            try
            {
                Console.Clear();
                if (list.Any())
                {
                    list.ForEach(option => Console.WriteLine(list.IndexOf(option) + "." + option.AssignmentTitle));
                    Console.WriteLine("\n" + "Choose assignment index that you want to update" + "\n");
                    assignment = Console.ReadLine();
                    int convertedUpdateAssignment = Convert.ToInt32(assignment);
                    if (list.Any(x => x == list[convertedUpdateAssignment]))
                    {
                        Console.WriteLine("\n" + "Assignments is done?" + "\n");
                        choice = Console.ReadLine();
                        if (choice is not null)
                        {
                            switch (choice)
                            {
                                case "no":
                                    Console.Clear();
                                    break;
                                case "yes":
                                    list[convertedUpdateAssignment].AssignmentStatus = "Done";
                                    list[convertedUpdateAssignment].AssignmentDate = DateTime.Now;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
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
