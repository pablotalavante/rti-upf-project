using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{	

	public GameObject env;
    public GameObject ball;

    void Start()
    {
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
    	if(other.tag=="Player"){
    		Vector3 deltaY = new Vector3(0, -100, 0);
    		env.transform.Translate(deltaY);
            Destroy(ball);
    	}
    	Debug.Log(other.tag);
    	Debug.Log("okey");
    }
}
