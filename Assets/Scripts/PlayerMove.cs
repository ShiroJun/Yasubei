using UnityEngine;
using System.Collections;

public class PlayerMove : MonoEX {
    public float speed;
    void Start()
    {
        Invoke("Destroy", 100);
    }
    //private float y = 90;
    // Update is called once per frame
    void FixedUpdate () {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(x * speed, 0, z * speed);


        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(0, -90, 0);
        //    //transform.position = new Vector3(0f, transform.position.y + 0.1f, 0f);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(0, 90, 0);
        //}


    }
}
