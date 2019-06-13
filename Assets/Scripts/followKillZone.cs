using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followKillZone : MonoBehaviour
{
    [Header("Objeto a seguir : ")]
    public GameObject followObject;
    private Vector3 camPosition;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camPosition = new Vector3(followObject.transform.position.x , -9f, -20f);
        transform.position = camPosition;
    }
}
