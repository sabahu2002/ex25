using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openbook : MonoBehaviour
{
    float bookAngle = 0;
    float openSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {


            bookAngle -= Time.deltaTime * openSpeed;
            bookAngle = Math.Clamp(-180, bookAngle, 0);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, bookAngle));

        }
        else if (Input.GetKey(KeyCode.A))
        {

            bookAngle += Time.deltaTime * openSpeed;
            bookAngle = Math.Clamp(bookAngle, 0, 180);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, bookAngle));
        }
    }
}
