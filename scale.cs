using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class scale : MonoBehaviour
{
    float max = 2f;
    float factor = 1f;
    float min = .001f;
    void Start()
    {

        factor = min;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            factor -= Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            factor += Time.deltaTime;
        }

        factor = Mathf.Clamp(factor, min, max);
        transform.localScale = Vector3.one * factor;
    }
}
