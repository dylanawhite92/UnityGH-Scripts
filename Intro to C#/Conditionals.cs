using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        evaluateGreater(4, 6);
        evaluateGreater(135, 135);
        evaluateGreater(12, 1);

        evaluateCase(5);
        evaluateCase(7);
        evaluateCase(1);
    }

    // Compare two integers, evaluate conditional based on args
    void evaluateGreater(int a, int b)
    {
        if (a > b)
        {
            print($"{a} is greater than {b}.");
        }
        else if (a == b)
        {
            print($"{a} is equal to {b}.");
        }
        else
        {
            print($"{b} is greater than {a}.");
        }
    }

    // Evaluate case based on arg
    void evaluateCase(int a)
    {
        switch (a)
        {
            case 1:
                print("A is equal to 1.");
                break;
            case 5:
                print("A is equal to 5.");
                break;
            case 6:
                print("A is equal to 6.");
                break;
            default:
                print("*BUZZER NOISE*");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
