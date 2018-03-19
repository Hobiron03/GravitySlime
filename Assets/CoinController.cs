using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    AudioSource audio;
    public AudioClip audioClip;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            AudioSource.PlayClipAtPoint(audioClip,transform.position);
            Destroy(this.gameObject);
        }
    }

}
