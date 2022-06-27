using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isJump = false;
    bool isTop = false;
    public float jumpHeight = 0;
    public float jumpSpeed = 0;

   Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0))
     {
        isJump = true;
        Debug.Log("A");
     }
        else if(transform.position.y <= startPosition.y)
     {
      isJump = false;
      isTop = false;
      transform.position = startPosition;
     }

     if (isJump) 
     {
            Debug.Log("B");
            Debug.Log(startPosition.y);
            Debug.Log(transform.position.y);
            Debug.Log(jumpHeight - 0.1f);
         if(transform.position.y <= jumpHeight - 0.1f && !isTop) {
                Debug.Log("C");
                transform.position = Vector2.Lerp(transform.position,
                    new Vector2(transform.position.x, jumpHeight), jumpSpeed * Time.deltaTime);
                Debug.Log(transform.position.y);
         }
         else
         {
            isTop = true;
         }
         if (transform.position.y > startPosition.y && isTop) {
            transform.position = Vector2.MoveTowards(transform.position, startPosition, jumpSpeed * Time.deltaTime);
         }
     }
    }
}
