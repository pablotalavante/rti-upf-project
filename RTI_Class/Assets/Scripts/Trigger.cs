using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{	
	public GameObject[] landmarks;
    public GameObject[] pathways;
    public GameObject reward;
    public GameObject participant;
    public int groupId;

    void Start()
    {
        landmarks = GameObject.FindGameObjectsWithTag("Landmark");
        pathways = GameObject.FindGameObjectsWithTag("Pathway");
        groupId = Random.Range(0, 2); //TODO: get from UI
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
    	if(other.tag=="Player"){
            // Vector3 deltaY = new Vector3(0, -100, 0);
            Debug.Log(groupId);

            if (groupId == 0) { // allocentric only
                foreach (GameObject obj in pathways)
                {
                    Destroy(obj); // destroy walls
                }
                participant.transform.Rotate(0.0f, Random.Range(45.0f, 225.0f), 0.0f, Space.Self); // randomly disoriented
            }  else if (groupId == 1) { // egocentric only
                foreach (GameObject obj in landmarks)
                {
                    //obj.transform.Translate(deltaY); 
                    Destroy(obj); // destroy landmarks
                }
            }   
            Destroy(reward); // destroy reward
    	}
    	Debug.Log(other.tag);
    	Debug.Log("okey");
    }
}
