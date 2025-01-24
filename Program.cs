namespace Week1_assignment_ksteph;

using DataHelper;

class Program
{
    static void Main()
    {
        // Will run until exit is selected
        while(true)
        {
            ShowMenu();
            int selection = Input.GetInt("", 1, 4, "Value must be between 1-4", "Value must be between 1-4");
            if (selection == 4) break;
            switch (selection)
            {
                case 1:
                    CharacterInfo.DisplayAllCharacters();
                    break;
                case 2:
                    CharacterInfo.NewCharacter();
                    break;
                case 3:
                    CharacterInfo.LevelUp();
                    break;
            }
        }
        
        Console.WriteLine("Thank you for using the RPG Character Editor.");
    }

    static void ShowMenu()
    {
        Console.WriteLine(
            "      Main Menu      \n" +
            "---------------------\n" +
            "1. Display Characters\n" +
            "2. New Character\n" +
            "3. Level Up Character\n" +
            "4. Exit\n" +
            "---------------------\n");
    }
}