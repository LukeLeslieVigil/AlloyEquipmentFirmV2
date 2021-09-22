using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    //private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    // Gameplay
    private bool hasShake = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        /*if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }*/

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.name == "ProteinShake")
        {
            Debug.Log("Got the shake!");
            Destroy(collision.gameObject);
            hasShake = true;
        }
        if (collision.gameObject.name == "Door")
        {
            if (hasShake == false)
            {
                Debug.Log("You must get the shake first!");
            }
            if (hasShake == true)
            {
                Debug.Log("You win!");
                Time.timeScale = 0;
            }         
        }
        /*if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("You've been caught! Game over.");
            Time.timeScale = 0;
        }*/
    }
}
