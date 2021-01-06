using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopMusic : MonoBehaviour
{

    private void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();

    }


}
