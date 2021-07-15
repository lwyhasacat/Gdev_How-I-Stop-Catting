using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_manager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.01f;
    private bool played = false;
    //public AudioClip catfood_audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(catfood.audiotrigger == true && played == false){
            audioSource.PlayOneShot(clip, volume);
            played = true;
        }
    }
}
