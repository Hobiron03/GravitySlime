using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Vector2 acc_vec;
    Vector3 gravityPosY = new Vector3(0, -9.7f, 0);
    Vector3 gravityNegY = new Vector3(0, 9.7f, 0);

    float power = 30.0f;
    float maxSpeed = 30.0f;
    Rigidbody2D rgbody;
	// Use this for initialization
	void Start () 
    {
        rgbody = this.GetComponent<Rigidbody2D>();

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
            Physics.gravity = gravityPosY;
        }
        else
        {
            Physics.gravity = gravityNegY; 
        }

        Debug.Log(Physics.gravity);

        rgbody.AddForce(acc_vec*power, ForceMode2D.Force);
    }
}
