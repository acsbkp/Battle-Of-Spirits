﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{   
    [Range(0f, 100f)]
    public float mouseSensivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
     Cursor.lockState = CursorLockMode.Locked;  
    }
		

	void Update(){
		
     float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
     float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

     xRotation -= mouseY;
     xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    
     this.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
     playerBody.Rotate(Vector3.up * mouseX);

    }
}
