using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVInputHandler : MonoBehaviour

{
    public GameObject InputField;
    public GameObject TVChannelDefault;
    public GameObject TVChannel17;

    void Update()
    {
        if InputField = ("17")
        {
            TVChannelDefault.SetActive(false);
            TVChannel17.SetActive(true);
        }
        else
        {
            TVChannel17.SetActive(false);
            TVChannelDefault.SetActive(true);
        }
    }
}
