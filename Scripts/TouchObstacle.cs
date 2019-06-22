using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObstacle : MonoBehaviour
{
    public int speed = 3;
    public int direction = 1;
    public GameObject player;
    public GameObject message;
    public GameObject button;
    public Camera camera;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
            message.SetActive(true);
            camera.transform.parent = null;
            player.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = direction * speed * Time.deltaTime;
        transform.position += new Vector3(x, 0, 0);

        if (transform.position.x > 24.5)
            direction = -1;

        if (transform.position.x < 15.5)
            direction = 1;

        if (message.activeInHierarchy)
            button.SetActive(true);
    }
}
