using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        float a = 5.4f;
        float b = 7.1f;

        // 'casting' or explicitly converting a float to an int
        int result = (int)a + (int)b;

        // concatenation
        print("The result of the operations on a & b is: " + result);

        // with interpolation
        print($"The result of a & b is: {result}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
