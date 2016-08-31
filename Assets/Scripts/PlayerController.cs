using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float PlayerMovingSpeed;
    public bool TeleportMode;

    void Start()
    {
        TeleportMode = true;
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
        GameObject Object = Coll.gameObject;
        float ObjectXPos = Object.GetComponent<Transform>().position.x;
        float ObjectYPos = Object.GetComponent<Transform>().position.y;

        if (TeleportMode)
        {
            if (Object.tag == "H_Arcade")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 3.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 3.5f, transform.position.y);
            }
            else if (Object.tag == "H_78")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 3.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 3.5f, transform.position.y);
            }
            else if (Object.tag == "H_Bell")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 5.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 5.5f, transform.position.y);
            }
            else if (Object.tag == "H_Cherry")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 1.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 1.5f, transform.position.y);
            }
            else if (Object.tag == "H_Gahoon")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 2.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 2.5f, transform.position.y);
            }
            else if (Object.tag == "H_Gate")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 2.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 2.5f, transform.position.y);
            }
            else if (Object.tag == "H_Kite")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 2.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 2.5f, transform.position.y);
            }
            else if (Object.tag == "H_LampPaper")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 1.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 1.5f, transform.position.y);
            }
            else if (Object.tag == "H_LampStone")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 1.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 1.5f, transform.position.y);
            }
            else if (Object.tag == "H_Pot")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 2.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 2.5f, transform.position.y);
            }
            else if (Object.tag == "H_Ramen")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 1.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 1.5f, transform.position.y);
            }
            else if (Object.tag == "H_SakuraFlower")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 5.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 5.5f, transform.position.y);
            }
            else if (Object.tag == "H_SakuraTrunk")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 1.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 1.5f, transform.position.y);
            }
            else if (Object.tag == "H_Vending")
            {
                if (ObjectXPos > transform.position.x)
                    transform.position = new Vector2(transform.position.x + 3.5f, transform.position.y);
                else if (ObjectXPos < transform.position.x)
                    transform.position = new Vector2(transform.position.x - 3.5f, transform.position.y);
            }
        }
    }
}
