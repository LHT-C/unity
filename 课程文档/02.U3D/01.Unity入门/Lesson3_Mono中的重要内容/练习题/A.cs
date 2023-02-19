using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        B b = this.GetComponent<B>();
        if( b != null )
        {
            b.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
