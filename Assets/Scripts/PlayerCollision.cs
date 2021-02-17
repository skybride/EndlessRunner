using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //reference from PlayerMovement script to PlayerCollision script

    void OnCollisionEnter (Collision collisionInfo) //called when there is a collision
    {
        if (collisionInfo.collider.tag == "Obstacle") //NOTE original we used .name but it is better practice to use tag
        {
            /*Debug.Log("we hit " + collisionInfo.collider.name);*/
            movement.enabled = false;

            //search for GameManger Script
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
