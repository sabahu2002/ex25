using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    public Transform tatget;
    private Vector3 def;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        def = transform.position - tatget.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newP = Vector3.Lerp(transform.position, tatget.position + def, 0.2f);
        transform.position = newP;
    }

}
