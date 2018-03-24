using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Vector2 acc_vec;
    private Vector3 gravUpY = new Vector3(0, -9.7f, 0);
    private Vector3 gravDownY = new Vector3(0, 9.7f, 0);

    private float power = 15.0f;
    private float maxSpeed = 7.0f;

    private Rigidbody2D rgbody;
    private AudioSource audio;

    private bool isGround;

    public AudioClip audioClip;
    public LayerMask blockLayer;
	// Use this for initialization
	void Start () 
    {
        rgbody = this.GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        audio.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () 
    {
      
	}

    void FixedUpdate()
    {
        
        acc_vec.x = Input.acceleration.x;
        acc_vec.y = Input.acceleration.y;

        if(acc_vec.y < 0f)
        {
            Physics.gravity = gravUpY;
        }
        else
        {
            Physics.gravity = gravDownY; 
        }

        float speedX = Mathf.Abs(rgbody.velocity.x);

        if (speedX < maxSpeed)
        {
            rgbody.AddForce(acc_vec * power, ForceMode2D.Force);
        }
    }
}
