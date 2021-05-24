using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAudioController : MonoBehaviour
{
   
    AudioSource source;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
    source = GetComponent<AudioSource>();
    rend = GetComponent<Renderer>();
    source.pitch = 1.75f / rend.bounds.size.magnitude;
    //print(“BoxSize: ” + rend.bounds.size.magnitude); 
    }

    // Update is called once per frame
    void Update()
    {

    }

      // método llamada por Unity cuando chocamos con algo …
    void OnCollisionEnter(Collision collision)
    {
    print("box.collision");
    source.Play();
    }
}
