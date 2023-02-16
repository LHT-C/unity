using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public A a;

    // Start is called before the first frame update
    void Start()
    {
        if( a != null )
           a.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
