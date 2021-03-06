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
    public int group; // 0, 1, 2 based on what kind of trial this is

    // Experiment state
    // 0 : searching
    // 1 : returning

    private int progression;
    private float start_time;

    public GameObject done_ui;

    public int GetProgress()
    {
        return progression;
    }

    public void StartTime()
    {
        start_time = Time.time;
    }

    public float TimeSinceStart()
    {
        return Time.time - start_time;
    }

    public void Progress()
    {
        progression = 1;
        done_ui.SetActive(true);
    }

    private void Awake()
    {
        progression = 0;
    }
}
