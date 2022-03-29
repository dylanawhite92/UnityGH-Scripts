using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialize array of 10 empty integer elements
        int[] newArray = new int[10];

        // Assign value to elements
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = Random.Range(0, 100);
            print($"The element at index {i} is {newArray[i]}");
        }

        print($"The length of newArray is {newArray.Length}");

        // Iterate through secondArray with foreach
        foreach (int num in newArray)
        {
            print(num);
        }

    }



    // Update is called once per frame
    void Update()
    {

    }
}
