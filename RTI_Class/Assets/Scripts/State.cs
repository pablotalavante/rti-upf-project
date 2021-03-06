using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    // This holds global experiment state, filled in by UI

    // Participant info
    public string first_name;
    public string age;
    public string gender; // m, f, na

    // Experiment info
    public int group; // 0 or 1 based on what kind of trial this is

    // Experiment state
    // 0 : starting menu
    // 1 : searching
    // 2 : returning

    private int progression;

    public int GetProgress()
    {
        return progression;
    }

    public void Progress()
    {
        progression = 1;

    }

    private void Awake()
    {
        progression = 0;
    }
}
