using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text textfield;
    [SerializeField] state startingstate;


    state currentState;
    state[] stateArray;
    void Start()
    {
        currentState = startingstate;
        textfield.text = currentState.getStateText();
        stateArray = currentState.getStateArray();
    }

    // Update is called once per frame
    void Update()
    {
        manageStates();
    }

    private void manageStates()
    {
        stateArray = currentState.getStateArray();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = stateArray[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = stateArray[1];
        }

        textfield.text = currentState.getStateText();
    }
}
