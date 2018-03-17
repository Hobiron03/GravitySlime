using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Vector2 acc_vec;
    float power = 30.0f;
    Rigidbody2D rgbody;
	// Use this for initialization
	void Start () 
    {
        rgbody = this.GetComponent<Rigidbody2D>();
       
	}
	
	// Update is called once per frame
	/*void Update () 
    {

        acc_vec.x = Input.acceleration.x;

        acc_vec.y = Input.acceleration.y;
        Debug.Log(acc_vec.y);

        if (acc_vec != null)
        {
            Physics.gravity = new Vector3(acc_vec.x*3, -acc_vec.y*3, 0);
        }
		
	}*/

    void FixedUpdate()
    {
        // 加速度与える
        acc_vec.x = Input.acceleration.x;
        acc_vec.y = Input.acceleration.y;

        rgbody.AddForce(acc_vec*power, ForceMode2D.Force);
    }
}
