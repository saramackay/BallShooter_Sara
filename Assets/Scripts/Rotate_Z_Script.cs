using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Z_Script : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 10) * Time.deltaTime * speed);
    }
}
