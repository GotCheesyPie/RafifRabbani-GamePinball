using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInTrigger : MonoBehaviour
{
  public Collider bola;
  public CameraScript cameraScript;
  public float length;
  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
        cameraScript.FollowTarget(bola.transform, length);
    }
  }
}
