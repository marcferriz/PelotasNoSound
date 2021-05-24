using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    // ARRAY ...
    AudioSource[] sources;
    Rigidbody rb;
    float speed = 0;
    float weight = 0;
    bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
    sources = GetComponents<AudioSource>();
    rb = GetComponent<Rigidbody>();
    weight = rb.mass;
    sources[1].pitch = 1.5f / rb.mass;
    }


    // Update is called once per frame
    void Update()
    {
    speed = rb.velocity.magnitude;
    if (speed > 0.1 && !isPlaying) {
        isPlaying = true;
        sources[0].Play();
    } else if (speed < 0.1 && isPlaying) {
        isPlaying = false;
        sources[0].Stop();
    }

    sources[0].pitch = speed / (weight * 2.5f);

    }


    // método llamada por Unity cuando chocamos con algo …
    void OnCollisionEnter(Collision collision)
    {
    print("collision");
    sources[1].Play();
    }


}
