using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject sfxBumperAudioSource;
    public GameObject sfxSwitchAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySFXBumper(Vector3 spawnPosition){
	    GameObject.Instantiate(sfxBumperAudioSource, spawnPosition, Quaternion.identity);
    }
    public void PlaySFXSwitch(Vector3 spawnPosition){
	    GameObject.Instantiate(sfxSwitchAudioSource, spawnPosition, Quaternion.identity);
    }
}
