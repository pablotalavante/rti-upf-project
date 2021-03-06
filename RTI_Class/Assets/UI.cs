using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Button start_trial_button;
    public InputField first_name_input;
    public InputField age_input;
    public InputField gender_input;
    public InputField group_input;

    public State state;

    void Start()
    {
        start_trial_button.onClick.AddListener(StartTrialOnClick);
    }
    void StartTrialOnClick()
    {
        state.first_name = first_name_input.text;
        state.age = age_input.text;
        state.gender = gender_input.text;
        state.group = int.Parse(group_input.text);

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
