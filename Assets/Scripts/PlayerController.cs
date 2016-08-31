using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public bool TeleportMode;

    void Start()
    {
        TeleportMode = true;
    }

	void Update ()
	{
        MovingKeyInput();

        if (TeleportMode)
            TeleportAlgorithm();
	}

    void TeleportAlgorithm()
    {
        TeleportRight(-4, 4.05f);
        TeleportRight(3, 4.05f);

        TeleportLeft(0, 4.05f);
        TeleportLeft(7, 4.05f);
    }

	void MovingKeyInput ()
	{
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + 0.05f, GetComponent<Transform>().position.y, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 0.05f, GetComponent<Transform>().position.y, 0);
        }
        else
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, 0);
        }
	}

    void TeleportRight(float StartTeleportPos, float TeleportDistance)
    {
        if ((Mathf.Abs(GetComponent<Transform>().position.x - StartTeleportPos) < 0.01f) && Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + TeleportDistance, GetComponent<Transform>().position.y, 0);
        }
    }

    void TeleportLeft(float StartTeleportPos, float TeleportDistance)
    {
        if ((Mathf.Abs(GetComponent<Transform>().position.x - StartTeleportPos) < 0.01f) && Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - TeleportDistance, GetComponent<Transform>().position.y, 0);
        }
    }
}
