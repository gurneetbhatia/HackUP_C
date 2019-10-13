using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class planeMovement : NetworkBehaviour {

    public Rigidbody2D rb;
    


    public float speed;

    float MovementY;

    private float Y_pos;

	
	// Update is called once per frame
	void Update () {
        if (hasAuthority== false )
        {
            return;
    }
        MovementY = Input.GetAxisRaw("Vertical") * (speed / 10);
        scrollScript.speed = 1f ;
        coins.speed = 5f;
        Y_pos = Mathf.Clamp(rb.transform.position.y, -5, 5);
        rb.transform.position =new Vector3(rb.transform.position.x,Y_pos, rb.transform.position.z);
    }

    public void FixedUpdate()
    {
        Move(MovementY);
    }
    public void Move(float i)
    {
        Vector2 displacement = new Vector2(rb.position.x, rb.position.y + i);
        rb.transform.position = displacement;

    }
}
