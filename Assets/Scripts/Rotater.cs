﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
  public float speed = 30f;

  void Update()
  {
    transform.Rotate(0f, speed * Time.deltaTime, 0f);
  }
}
