using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public HingeJoint left;
    public HingeJoint right;
    public float springPower;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring leftSpring = left.spring;
        JointSpring rightSpring = right.spring;

        if(Input.GetKey(KeyCode.Z)){
            leftSpring.spring = springPower;
        }
        else {
            leftSpring.spring = 0;            
        }
        if(Input.GetKey(KeyCode.M)){
            rightSpring.spring = springPower;
        }
        else{
            rightSpring.spring = 0;
        }

        left.spring = leftSpring;
        right.spring = rightSpring;
    }
}
