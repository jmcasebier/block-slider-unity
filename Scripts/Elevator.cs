using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
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
        float y = direction * speed * Time.deltaTime;
        transform.position += new Vector3(0, y, 0);

        if (transform.position.y > 6.75)
            direction = -1;

        if (transform.position.y < -.75)
            direction = 1;
    }
}
