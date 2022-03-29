using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 11; i++)
        {
            print(i);
        }

        int j = 22;

        while (j < 34)
        {
            print(j);
            j++;
        }

        int k = 5;

        do
        {
            print(k);
            k++;
        } while (k < 16);
    }



    // Update is called once per frame
    void Update()
    {

    }
}
