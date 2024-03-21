using Ness_Project_Nadav_Arania.Controllers;

CommandController commandController = new CommandController();

//Loop of app until condition change to keep app going
do
{
    Console.WriteLine("To Do List Menu:" + "\n");
    commandController.list.ForEach(x => Console.WriteLine("Assignment Title: " + x.AssignmentTitle + "\n" + "Assignment Date: " + x.AssignmentDate + "\n" + "Assignment Status: " + x.AssignmentStatus + "\n" + "\n"));
    Console.WriteLine("\n");
    commandController.options.ForEach(option => Console.WriteLine(option));
    Console.WriteLine("\n" + "Write which command do you want to execute." + "\n");
    //Loop until write correct command to execute
    do
    {
        commandController.choice = Console.ReadLine().ToLower();
        if (commandController.choice is not null && commandController.options.Any(x => x.ToLower() == commandController.choice))
        {
            switch (commandController.choice)
            {
                case "add":
                    commandController.AddAssignment();
                    break;
                case "remove":
                    commandController.RemoveAssignment();
                    break;
                case "update":
                    commandController.UpdateAssignment();
                    break;
                case "exit":
                    commandController.Exit();
                    break;

            }
            commandController.approved = true;
        }
        else
        {
            Console.WriteLine("\n" + "Please try again" + "\n");
        }
    } while (!commandController.approved);

    //Check if go out from app or stay
    Console.WriteLine("\n" + "Do you want to go back to menu? If you do want to keep going write Yes, otherwise write No" + "\n");
    commandController.choice = Console.ReadLine().ToLower();
    if (commandController.choice is not null)
    {
        switch (commandController.choice)
        {
            case "no":
                commandController.keepGoing = false;
                break;
            case "yes":
                commandController.keepGoing = true;
                Console.Clear();
                break;
            default:
                Console.WriteLine("\n" + "Going back to main menu." + "\n");
                commandController.keepGoing = true;
                Console.Clear();
                break;
        }
    }
} while (commandController.keepGoing);