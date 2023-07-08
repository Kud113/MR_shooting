using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField]
    AudioClip[] audioClips;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play(string seName)
    {
        switch (seName)
        {
            case "SE0":
                audioSource.PlayOneShot(audioClips[0]);
                break;
            case "SE1":
                audioSource.PlayOneShot(audioClips[1]);
                break;
            case "SE2":
                audioSource.PlayOneShot(audioClips[2]);
                break;
        }
    }
}
