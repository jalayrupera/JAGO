using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello Jalay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {
        if(input == "1")
        {
            StartGame(1);
        }
        else if (input == "menu")
        {
            print("You choose main menu");
            Terminal.ClearScreen();
            ShowMainMenu("Hello Jalay");
        }
        else
        {
            Terminal.WriteLine("Enter a valid choice");
        }
    }

    //  To show the main menu
    void ShowMainMenu(string name)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(name);
        Terminal.WriteLine("So What would you like to hack?");
        Terminal.WriteLine("Enter 1 to hack Libarary server");
        Terminal.WriteLine("Enter 2 to hack Police Station");
        Terminal.WriteLine("Enter your choice: ");
    }
    void StartGame(int level)
    {
        Terminal.WriteLine("You have choosen level " + level);
    }
}
