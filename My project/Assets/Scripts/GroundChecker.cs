using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] Transform player;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="ground")
        {
            playerController.isGrounded = true;
            player.SetParent(collision.gameObject.transform);
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            playerController.isGrounded = false;
            player.SetParent(null);
        }
    }
}
