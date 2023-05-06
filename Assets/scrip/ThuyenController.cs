using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThuyenController : MonoBehaviour
{
    bool isMoving = true;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}
    float speed = 1f;

    //// Update is called once per frame
    void Update()
    {
        if (isMoving)
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        if (transform.position.x >= 9) isMoving = false;
    }

    public int health; // Máu của thuyền

    public void TakeDamage(int damage)
    {
        health -= damage; // Giảm máu của thuyền
        if (health <= 0)
        {
            Destroy(gameObject); // Nếu thuyền đã hết máu thì tiêu diệt thuyền
        }
    }
}
