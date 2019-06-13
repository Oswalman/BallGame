using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(new Vector2(0, -1f)));

        if (hit.collider!=null)
        {
            Debug.Log("Colisión abajo");
            Debug.Log(hit.collider.name);
        }
    }
}
