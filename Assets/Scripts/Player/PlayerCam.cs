using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerCam : MonoBehaviour
{
    public float mouseSensitivity;

    float XRotation;
    float YRotation;

    private void Start()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mouseSensitivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSensitivity;

        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        YRotation += mouseX;

        transform.localRotation = Quaternion.Euler(XRotation, YRotation, 0f);

        transform.parent.rotation *= Quaternion.Euler(0f, YRotation, 0f);
    }
}
