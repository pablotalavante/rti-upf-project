using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneUI : MonoBehaviour
{
    public State state;

    public Button done_button;

    void Start()
    {
        done_button.onClick.AddListener(EndTrialOnClick);
        gameObject.SetActive(false);
    }

    void EndTrialOnClick()
    {
        Debug.Break();
        Application.Quit();
    }
}
