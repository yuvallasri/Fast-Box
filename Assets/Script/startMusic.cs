using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMusic : MonoBehaviour
{
    public GameObject Music;
    private void Start()
    {
        Music.GetComponent<Music>().PlayMusic();

    }

}
