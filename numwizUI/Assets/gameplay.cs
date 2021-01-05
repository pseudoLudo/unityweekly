using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameplay : MonoBehaviour
{
    // Start is called before the first frame update
    private int mid, guess;
    [SerializeField] int min = 0, max = 1000;
    [SerializeField] TextMeshProUGUI guessText;
    void Start()
    {
        starter();
    }

    // Update is called once per frame
    void Update()
    {
        //resultcheck();
    }

    void starter()
    {
        min = 0; max = 1000;
        guess = Random.Range(min, max);
        mid = Random.Range(min, max);
        max++;
        guessText.text = mid.ToString();
    }

    public void onHigh()
    {
        min = mid;
        midsetter();
    }
    public void onLow()
    {
        max = mid;
        midsetter();
    }
    void midsetter()
    {
        mid = Random.Range(min, max);
        Debug.Log("is it higher or lower than:" + mid);
        guessText.text = mid.ToString();
    }

   public  void resultcheck()
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