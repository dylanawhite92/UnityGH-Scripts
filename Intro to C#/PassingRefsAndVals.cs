using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // create new player object using NewPlayer constructor
        NewPlayer mainCharacter = new NewPlayer("Billy Corgan", 144.3f, "Wizard");

        mainCharacter.PlayerInfo();
        print("\n");

        // change values by passing to ChangePlayer func
        ChangePlayer(mainCharacter);
        mainCharacter.PlayerInfo();
    }

    // pass values/refs to func params
    void ChangePlayer(NewPlayer p)
    {
        p.name = "Changed the name in the function";
    }
}
