 using UnityEngine;
 using System.Collections;
 
 public class ControlFPS : MonoBehaviour
{
    // horizontal rotation speed
    public float horizontalSpeed = 10f;
    // vertical rotation speed
    public float verticalSpeed = 10f;
    public float xRotation = 0.0f;
    public float yRotation = 0.0f;
    private Camera cam;

    CharacterController characterController;
    public float movementSpeed = 20f;
    public float gravity = 9.8f;
    private float velocity = 0;

    public bool move = false;

    void Start()
    {
        cam = Camera.main;
        characterController = GetComponent<CharacterController>();
    }

    public void ToggleMove(){
        move = !move;
    }

    void Update()
    {   
        if (move)
        {
            float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

            yRotation += mouseX;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90, 90);

            cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

            // player movement - forward, backward, left, right
            float horizontal = Input.GetAxis("Horizontal") * movementSpeed;
            float vertical = Input.GetAxis("Vertical") * movementSpeed;
            characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);
            
            // move by clicking
            if (Input.GetMouseButtonDown(0)) {
                RaycastHit hit;
                
                if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                    characterController.Move(hit.point - characterController.transform.position);
                }
            }

            // gravity
            if(characterController.isGrounded)
            {
                velocity = 0;
            }
            else
            {
                velocity -= gravity * Time.deltaTime;
                characterController.Move(new Vector3(0, velocity, 0));
            }
        }
    }
}