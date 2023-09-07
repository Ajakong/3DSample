using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody myRb;

    float rotate=0;
    Vector3 move;
    Vector3 angle;
    // Start is called before the first frame update
    void Start()
    {
       
        angle = new Vector3(0, 0.1f, 0);
        myRb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move = transform.forward * 0.02f;
        if (Input.GetKey(KeyCode.W))
        {
            
            
            myRb.position += move;
            
        }
        if (Input.GetKey(KeyCode.S))
        {
           
            
            myRb.position -= move;
           
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotate+=0.1f;
            
            this.transform.rotation=Quaternion.AngleAxis(rotate, angle);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotate -= 0.1f;
           
            this.transform.rotation = Quaternion.AngleAxis(rotate, angle);
        }
    }
}
