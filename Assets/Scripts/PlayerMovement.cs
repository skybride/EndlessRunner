using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    /*    public float sidewaysForce = 500f;*/
    public float sidewaysForce = 100f;

    public Joystick joystick;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.deltaTime even out frame rate

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


        //Mobile
        /*        if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    touchPosition.z = 0f;
                    transform.position = touchPosition;
                }*/

        //sidewaysForce = joystick.Horizontal * Time.deltaTime;

        if (joystick.Horizontal >= .2f )
        {
            rb.AddForce((sidewaysForce/3) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (joystick.Horizontal <= -.2f)
        {
            rb.AddForce(-(sidewaysForce/3 )* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(0,0,0);
        }
    }
}
