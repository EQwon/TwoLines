using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float PlayerMovingSpeed;

    void Start()
    {
        
    }

	void Update ()
	{
        MovingKeyInput();
	}

	void MovingKeyInput ()
	{
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(PlayerMovingSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-PlayerMovingSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
