using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** References: 
Audio: https://stackoverflow.com/questions/59439413/how-to-loop-an-audio-in-unity
https://docs.unity3d.com/ScriptReference/AudioSource-clip.html
**/


public class Audio : MonoBehaviour
{
    public AudioClip normalBgm;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = normalBgm;
        audio.loop = true;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
