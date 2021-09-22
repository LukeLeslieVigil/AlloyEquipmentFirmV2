using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadAnimationController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            //when pressing a direction button, plays walking animation
            anim.SetBool("isWalking", true);
        }

        if (!Input.GetKey("w"))
        {
            anim.SetBool("isWalking", false);
        }

        //run this line of code when player gets caught
        //if(playerCaught = true {anim.SetBool("isCaught", true);}
    }
}
