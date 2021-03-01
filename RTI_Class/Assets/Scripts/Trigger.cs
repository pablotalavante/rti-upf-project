using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{	

	public GameObject env;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
    	if(other.tag=="Player"){
    		Vector3 deltaY = new Vector3(0, -100, 0);
    		env.transform.Translate(deltaY);
    	}
    	Debug.Log(other.tag);
    	Debug.Log("okey");
    }
}
