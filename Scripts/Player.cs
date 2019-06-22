using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5.0f;
    public GameObject message;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += new Vector3(x, 0, z);

        if (transform.position.y < -8)
            message.SetActive(true);

        if (message.activeInHierarchy)
            button.SetActive(true);
    }
}
