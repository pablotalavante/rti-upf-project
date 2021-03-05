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
    public int group; // 1, 2, or 3 based on what kind of trial this is

    // Experiment state
    // 1 : searching
    // 2 : returning

    public int progression;
}
