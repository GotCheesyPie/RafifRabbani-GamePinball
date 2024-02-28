using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BGMScript : MonoBehaviour
{
    private GameObject mainCamera;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        transform.position = mainCamera.transform.position;
    }
}
