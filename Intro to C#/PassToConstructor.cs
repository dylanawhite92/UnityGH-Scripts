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
    }
}
