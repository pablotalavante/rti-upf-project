 using UnityEngine;
 using System.Collections;
 
 public class ControlFPS : MonoBehaviour
{
    // horizontal rotation speed
    public float horizontalSpeed = 10f;
    // vertical rotation speed
    public float verticalSpeed = 10f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;

    CharacterController characterController;
    public float MovementSpeed =2;
    public float Gravity = 9.8f;
    private float velocity = 0;

    void Start()
    {
        cam = Camera.main;
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

        // player movement - forward, backward, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);
        
        // Gravity
        if(characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= Gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }
}