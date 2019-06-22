using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
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

        if (transform.position.z > 4.5)
            direction = -1;

        if (transform.position.z < -4.5)
            direction = 1;
    }
}
