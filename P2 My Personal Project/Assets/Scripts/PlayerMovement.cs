using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject powerupIndicator;
    public AudioClip powerSound;
    private AudioSource playerAudio;
    private float speed = 15.0f;
    private float turnSpeed = 210.0f;
    private float horizontalInput;
    private float forwardInput;
     private float zBound = 18.0f; 
     private float xBound = 23.0f;

     
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // The movement of the player and where the player can and cannnot go
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
         transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
         transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
          
          if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        
    } // this is where the powerups will be able to give points to the player if collided with
private void OnTriggerEnter(Collider other)
{
    if(other.gameObject.CompareTag("Powerup"))
{
    ScoreManager.instance.AddPoint();
    Destroy(other.gameObject);
    playerAudio.PlayOneShot(powerSound, 1.0f);
}
}// if the player were to collide with the enemy the game would pause and the game over screen will show up.
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            PlayerManager.isGameOver = true;
            Time.timeScale = 0f;
        }
    }
   
}
