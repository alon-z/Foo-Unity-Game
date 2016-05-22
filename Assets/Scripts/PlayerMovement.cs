using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public int SPEED;
    public Rigidbody player;

    private Rect leftZone = new Rect(0, 0, Screen.width / 2, Screen.height);
    private Rect rightZone = new Rect(Screen.width / 2, 0, Screen.width, Screen.height);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 100% Sure updates
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            //float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3();

            if (leftZone.Contains(Input.GetTouch(0).position)) {
                movement = new Vector3(-1.0f, 0.0f, 0.0f);
            }

            if (rightZone.Contains(Input.GetTouch(0).position))
            {
                movement = new Vector3(1.0f, 0.0f, 0.0f);
            }

            player.AddForce(movement * SPEED);
        }
    }
}
