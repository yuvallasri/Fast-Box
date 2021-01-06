using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {

         DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying)
        {
            Debug.Log("do nothing");
        }
          
       else _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
