using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movVertical : MonoBehaviour
{
    public AnimationCurve myCurve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newY = 5 * Mathf.Sin(Time.time * 2f);
        transform.position = new Vector2(transform.position.x, 15f+newY);
    }
}
