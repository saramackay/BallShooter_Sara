using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Vertical : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 0, 0) * Time.deltaTime * speed);
    }
}
