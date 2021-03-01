using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public float speed;
	public float speedR;
	float walkSpeed;
	float runSpeed;

	// Use this for initialization
	void Awake()
	{

	}

	
	// Update is called once per frame
	void FixedUpdate () {
	
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
			GetComponent<CharacterController>().Move(transform.forward * speed);
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) { 
           GetComponent<CharacterController>().Move(transform.forward* -1 * speed);
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) { 
            transform.Rotate(Vector3.down* 1 * speedR);
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down* -1  * speedR);
		}

	}
}
