using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThuyenSmallController : MonoBehaviour
{
    bool isMoving = true;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        if (transform.position.x >= 9) isMoving = false;
       
    }
}
