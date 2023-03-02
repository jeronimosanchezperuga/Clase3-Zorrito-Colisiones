using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "gem-1" || col.gameObject.name == "Zorrito")
        {
            Destroy(col.gameObject);
        }
    }

    void OnCollisionExit()
    {

    }

    void OnCollisionStay()
    {

    }
}
