using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttach : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = transform;
            rb.isKinematic = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = null;
            rb.isKinematic = false;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
