using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Vector2 acc_vec;
    Vector3 gravUpY = new Vector3(0, -9.7f, 0);
    Vector3 gravDownY = new Vector3(0, 9.7f, 0);

    float power = 15.0f;
    float maxSpeed = 7.0f;

    Rigidbody2D rgbody;
    AudioSource audio;
    public AudioClip audioClip;
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
        // 加速度与える
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ぶつかったよ");
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("ground");
            audio.Play();
        }
    }
}
