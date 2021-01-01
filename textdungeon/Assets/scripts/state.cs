using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "State")]
public class state : ScriptableObject
{
    [TextArea(14,10)][SerializeField] string stateText;
    [SerializeField] state[] stateArray;

    public string getStateText()
    {
        return stateText;
    }

    public state[] getStateArray()
    {
        return stateArray;
    }
}
