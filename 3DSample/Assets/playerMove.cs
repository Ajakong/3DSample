using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    GameObject Sword;
    Rigidbody myRb;
    Sword sword;

    int rolltimer=0;
    float rotate=0;
    bool rollFlag=false;
    bool swordFlag;
    Vector3 move;
    Vector3 angle;

    Vector3 x,y,z;
    Vector3 rolling;
    // Start is called before the first frame update
    void Start()
    {
        Sword = GameObject.Find("Sword");
        Sword.SetActive(false);
        angle = new Vector3(0, 0.1f, 0);
        myRb = this.GetComponent<Rigidbody>();
        sword =GetComponent<Sword>();
        
        rolling=new Vector3 (0.1f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
           
        }
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

        if(swordFlag==true)
        {
            Sword.SetActive(true);
        }
    }
    private void FixedUpdate()
    {
        if (rollFlag == true)
        {
            if (rolltimer < 11)
            {
                this.transform.RotateAround(this.transform.position+move, rolling, 36.0f);
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
