using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Platform : MonoBehaviour
{
    public float speed = 0;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,10,0) * Time.deltaTime * speed);
    }
}
