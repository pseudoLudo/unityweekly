using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binaryBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int min=0, max=1000,mid,guess;
    void Start()
    {
        starter();
    }

    // Update is called once per frame
    void Update()
    {
        controller();
        resultcheck();
    }

    void starter()
    {
        Debug.Log("Its the guessing game!");
        Debug.Log("guess the number between 1,1000");
        min = 0; max = 1000;
        guess = Random.Range(min, max);
        mid = (min + max) / 2;

        max++;
        Debug.Log("is it above or below" + " " + mid);
    }
    void controller()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = mid;
            midsetter();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = mid;
            midsetter();
        }
    }
    void midsetter()
    {
        mid = (min + max) / 2;
        Debug.Log("is it higher or lower than:" + mid);
    }

    void resultcheck()
    {
        if (guess == mid)
        {
            Debug.Log("you reached it");
            Start();
        }
        else if (mid == min || mid == max)
        {
            Debug.Log("did not reach it");
            Start();
        }
    }
}
