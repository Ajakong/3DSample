using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody myRb;

    int rolltimer=0;
    float rotate=0;
    bool rollFlag=false;
    Vector3 move;
    Vector3 angle;

    Vector3 x,y,z;
    Quaternion rolling;
    // Start is called before the first frame update
    void Start()
    {
       
        angle = new Vector3(0, 0.1f, 0);
        myRb = this.GetComponent<Rigidbody>();

        x=new Vector3 (0.1f,0,0);
        rolling=new Quaternion(0.01f, 0, 0,0);
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rollFlag = true;

        }
    }
    private void FixedUpdate()
    {
        if (rollFlag == true)
        {
            if (rolltimer < 10)
            {
                this.transform.rotation = Quaternion.AngleAxis(rotate, angle);
                myRb.position += move * 30;
                rolltimer++;
            }
            else
            {
                rolltimer = 0;
                rollFlag = false;
            }
        }


    }
}
