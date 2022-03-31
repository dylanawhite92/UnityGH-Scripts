using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // create new player objects
        NewPlayer mainCharacter = new NewPlayer();
        NewPlayer secondCharacter = new NewPlayer();
        NewPlayer thirdCharacter = new NewPlayer();

        // assign first character's values
        mainCharacter.health = 100f;
        mainCharacter.name = "Jorbin Honkydonk";
        mainCharacter.characterClass = "Warrior";

        // assign second character's values
        secondCharacter.health = 75f;
        secondCharacter.name = "Honkytonk Badonkadonk";
        secondCharacter.characterClass = "Rogue";

        // assign third character's values
        thirdCharacter.health = 45f;
        thirdCharacter.name = "Billy Corgan";
        thirdCharacter.characterClass = "Wizard";

        mainCharacter.PlayerInfo();
        secondCharacter.PlayerInfo();
        thirdCharacter.PlayerInfo();
    }
}
