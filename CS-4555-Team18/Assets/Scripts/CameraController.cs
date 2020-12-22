using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraController : MonoBehaviour
{
    public InputAction lookCamera;

    public float mouseSensitivity = 10f;

    public Transform playerBody;

    float xRotation = 0f;

    void OnEnable()
    {
        lookCamera.Enable();
    }

    void OnDisable()
    {
        lookCamera.Disable();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Vector2 inputVector = lookCamera.ReadValue<Vector2>();

        float mouseX = inputVector.x * mouseSensitivity * Time.deltaTime;
        float mouseY = inputVector.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);


    }
}
