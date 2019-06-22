using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public int speed = 3;
    public int direction = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float z = direction * speed * Time.deltaTime;
        transform.position += new Vector3(0, 0, z);

        if (transform.position.z > 13.5)
            direction = -1;

        if (transform.position.z < 6.5)
            direction = 1;
    }
}
