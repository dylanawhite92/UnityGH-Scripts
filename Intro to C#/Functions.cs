using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        addTwoNumbers(16, 30);

        print($"The product of c and d is {returnTwoNumbers(77, 11)}");
    }

    // void declares that no values will be returned by a func
    void addTwoNumbers(int a, int b)
    {
        print($"The sum of a and b is {a + b}.");
    }

    // func that returns a value
    int returnTwoNumbers(int a, int b)
    {
        return a * b;
    }
}
