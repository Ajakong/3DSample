using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    static public bool ShaveFlag = false;
    public bool SwordFlag = false;

    string targetName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)                 // “–‚½‚è”»’è‚ðŽ@’m
    {
        if (collision.gameObject.name == targetName)
        {
            ShaveFlag = true;
        }
    }
}
