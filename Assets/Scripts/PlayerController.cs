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

    void OnTriggerEnter2D(Collider2D Coll)
    {
        if (Coll.gameObject.tag == "Object")
        {
            GameObject Object = Coll.gameObject;
            float ObjectXSize = Object.GetComponent<BoxCollider2D>().size.x;
            float ObjectYSize = Object.GetComponent<BoxCollider2D>().size.y;
            float ObjectXPos = Object.GetComponent<Transform>().position.x;
            float ObjectYPos = Object.GetComponent<Transform>().position.y;

            if (ObjectXPos > transform.position.x)
                Debug.Log("Left");
            else if (ObjectXPos < transform.position.x)
                Debug.Log("Right");
        }
    }
}
