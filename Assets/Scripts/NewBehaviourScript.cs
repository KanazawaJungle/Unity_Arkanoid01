using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void FizzBuzz()
    {
        int[] xs = new int[31];
        for(int i=1;i<=30;i++)
        {
            xs[i] = i;
            if (i % 5 == 0 && i % 3 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else
            {
                Debug.Log(i);
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        FizzBuzz();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}