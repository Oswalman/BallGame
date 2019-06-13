using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHide : MonoBehaviour
{
    [Header("Time out: ")]
    public float tiempo;
    public GameObject textHider;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(textKiller());
    }



    // Update is called once per frame
    private IEnumerator textKiller()
    {
        yield return new WaitForSeconds(tiempo);
        gameObject.SetActive(false);
        // Destroy(gameObject);
    }
}