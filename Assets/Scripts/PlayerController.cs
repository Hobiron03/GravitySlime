using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Vector2 acc_vec;
    private Vector3 gravUpY = new Vector3(0, -9.7f, 0);
    private Vector3 gravDownY = new Vector3(0, 9.7f, 0);
    private Vector3 gravDownX = new Vector3(-9.7f, 0, 0);
    private Vector3 gravUpX = new Vector3(9.7f, 0, 0);

    private float power = 13.0f;
    private float maxSpeed = 6.0f;

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


        if(-0.7f < acc_vec.y && acc_vec.y < -1.2f)
        {
            Physics.gravity = gravDownY; 
            //Debug.Log(Physics.gravity);
        }
        else if (0.7f < acc_vec.y && acc_vec.y < 1.2f)
        {
            Physics.gravity = gravUpY;
            //Debug.Log(Physics.gravity);
        }
        else if(-0.7f < acc_vec.x && acc_vec.x < -1.2f)
        {
            Physics.gravity = gravDownX;
        }
        else if (0.7f < acc_vec.x && acc_vec.x < 1.2f)
        {
            Physics.gravity = gravUpX;
            //Debug.Log(Physics.gravity);
        }

        float speedX = Mathf.Abs(rgbody.velocity.x);

        if (speedX < maxSpeed)
        {
            rgbody.AddForce(acc_vec * power, ForceMode2D.Force);
        }
    }
}
