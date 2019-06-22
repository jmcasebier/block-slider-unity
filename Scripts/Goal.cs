using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject message;
    public GameObject button;
    public GameObject player;
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
        if (message.activeInHierarchy)
            button.SetActive(true);
    }
}
