using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialize array of 10 elements
        int[] newArray = new int[10];

        ProcessArray(newArray);
        ReturnArrays(secondArray);
    }

    // Add value to elements of array with separate function
    void ProcessArray(int[] passedArray)
    {
        for (int i = 0; i < passedArray.Length; i++)
        {
            passedArray[i] = Random.Range(0, 100);
            print($"Value: {passedArray[i]}");
        }
    }

    // Declare but do not initialize second array
    int[] secondArray;

    // Initialize and return array of integers
    int[] ReturnArrays(int[] arrayToReturn)
    {
        arrayToReturn = new int[5];

        for (int i = 0; i < arrayToReturn.Length; i++)
        {
            arrayToReturn[i] = Random.Range(100, 1000);
            print($"Value: {arrayToReturn[i]}");
        }


        return arrayToReturn;
    }
}
