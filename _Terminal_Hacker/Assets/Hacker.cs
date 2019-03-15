using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var greetings = "Hello Jalay";
        Terminal.WriteLine(greetings);
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //  To show the main menu
    void ShowMainMenu()
    {
        //Terminal.ClearScreen();
        Terminal.WriteLine("So What would you like to hack?");
        Terminal.WriteLine("Enter 1 to hack Libarary server");
        Terminal.WriteLine("Enter 2 to hack Police Station");
        Terminal.WriteLine("Enter your choice: ");
    }
}
