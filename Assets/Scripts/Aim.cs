﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAime : MonoBehaviour
{

  public float mouseSensitivity = 101f;

  public Transform playerBody;

  private float xRotation = 0f;

  void Start()
  {
    // !Musen syns ej
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
  }
  void Update()
  {
    // !Aim
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f);

    transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    playerBody.Rotate(Vector3.up * mouseX);
}
}
