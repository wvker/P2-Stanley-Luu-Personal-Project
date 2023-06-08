using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5.0f;
    private float zDestroy = -17.5f;
    private Rigidbody objectRb;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // This is where aliens will be moving down and being deleted after leaving the player's view
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);
        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
