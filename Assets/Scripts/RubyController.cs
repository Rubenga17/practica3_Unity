using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         float horizontal = Input.GetAxis("Horizontal");
         float vertical = Input.GetAxis("Vertical");
        
         Vector2 position = transform.position;
         position.x = position.x + 3.0f* horizontal * Time.deltaTime;
         position.y = position.y + 3.0f * vertical * Time.deltaTime;
         transform.position = position;

         rigidbody2d.MovePosition(position);
    }
}
