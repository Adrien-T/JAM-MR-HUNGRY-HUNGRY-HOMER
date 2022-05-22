using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderProps : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip munch;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = munch;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Prop")
        {
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Family")
        {
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
        }
    }
    void Update()
    {
        
    }
}
