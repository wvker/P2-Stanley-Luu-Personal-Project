using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isRunning", true);

        }
         if (!Input.GetKey("w"))
        {
            animator.SetBool("isRunning", false);

            
        }
        if (Input.GetKey("s"))
        {
            animator.SetBool("isWalking", true);
          
        }
         if (!Input.GetKey("s"))
        {
            animator.SetBool("isWalking", false);
        }
    }
}
