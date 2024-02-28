using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutTrigger : MonoBehaviour
{
  public Collider bola;
  public CameraScript cameraScript;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
        cameraScript.GoBackToDefault();
    }
}
}
