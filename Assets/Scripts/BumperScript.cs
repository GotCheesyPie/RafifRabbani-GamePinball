using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public AudioManager audioManager;
    public VFXManager vFXManager;
    public ScoreManager scoreManager;
    public float score;

    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    private void OnCollisionEnter(Collision collision){
        if(collision.collider == bola){
            Rigidbody rb = bola.GetComponent<Rigidbody>();
            rb.velocity *= multiplier;

            animator.SetTrigger("hit");
            audioManager.PlaySFXBumper(collision.transform.position);
            vFXManager.PlayVFXBumper(collision.transform.position);
            scoreManager.AddScore(score);
        }
    }
}
