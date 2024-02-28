using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float maxSpeed;
    private Rigidbody rig;
    private Vector3 initLocation;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        initLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (rig.velocity.magnitude > maxSpeed)
        {
            rig.velocity = rig.velocity.normalized * maxSpeed;
        }
        
    }
    public void Respawn()
    {
        transform.position = initLocation;
    }
}
