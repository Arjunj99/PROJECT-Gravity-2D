using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Vector3 velocity;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + velocity * Time.deltaTime);
        if (Input.GetKey(God.IM.right)) // Controls Right
        {
            velocity.x = Mathf.Lerp(velocity.x, God.GSM.rightVelocity.x, 0.1f);
        }
        if (Input.GetKey(God.IM.left)) // Controls Right
        {
            velocity.x = Mathf.Lerp(velocity.x, -God.GSM.rightVelocity.x, 0.1f);
        }
        if (Input.GetKey(God.IM.up)) // Controls Right
        {
            velocity.y = Mathf.Lerp(velocity.y, God.GSM.rightVelocity.y, 0.1f);
        }
        if (Input.GetKey(God.IM.down)) // Controls Right
        {
            velocity.y = Mathf.Lerp(velocity.y, -God.GSM.rightVelocity.y, 0.1f);
        }
    }
}
