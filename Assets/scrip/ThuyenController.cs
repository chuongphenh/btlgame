using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThuyenController : MonoBehaviour
{
    bool isMoving = true;
    bool isDie = true;
    SpriteRenderer sprite;
    Color color;

    public float speed = 1f;
    float speedChet = 0.02f;

    public int health1; // Máu của thuyền
    public int health2;
    public int health3;
    public AudioClip soundEffect;

    public static bool isDestroyed = false;
    public static bool isDestroyed1 = false;
    public static bool isDestroyed2 = false;
    public bool ischeck = false;
    public int health; // Máu của thuyền

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        color = sprite.color;

    }

    void OnDestroy()
    {
    }


    //// Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (!isMoving && isDie)
        {
            // Mờ dần và di chuyển xuống dưới
            color.a -= 0.009f;
            sprite.color = color;
            transform.Translate(Vector3.down * Time.deltaTime * speedChet * 100f);

            if (color.a <= 0.1f)
            {
                Destroy(gameObject);
            }
           

        }
        //if (transform.position.x >= 6f)
        //{
        //    isMoving = false;
        //}
    }

    public void TakeDamage(int damage)
    {
        // Giảm máu của thuyền
        health1 -= damage;
        health2 -= damage;
        health3 -= damage;

        if (health1 <= 0)
        {
            if (gameObject.tag == "thuyen1" && isMoving == false )
            {
                isDestroyed = true;
            }
        }

        if (health2 <= 0)
        {
            if (gameObject.tag == "thuyen2" && isMoving == false)
            {
                isDestroyed1 = true;
            }
        }

        if (health3 <= 0)
        {
            if (gameObject.tag == "thuyen3" && isMoving == false )
            {
                isDestroyed2 = true;
            }
        }

        if (health1 <= 0)
        {
            Score.score += 10;
            isMoving = false;
            isDie = true;
        }
        if (health2 <= 0)
        {
            Score.score += 20;
            isMoving = false;
            isDie = true;
          
        }
        if (health3 <= 0)
        {
            Score.score += 30;
            isMoving = false;
            isDie = true;
        }

        

        // Nếu thuyền đã hết máu thì cập nhật điểm số và tiêu diệt thuyền
        if (!isMoving)
        {
            if (Score.score > Score.highScore)
            {
                Score.highScore = Score.score;
                PlayerPrefs.SetInt("HighScore", Score.score);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dan")
        {
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }
        if (collision.gameObject.tag == "dao")
        {
            isMoving = false;
            isDie = false;
        }
    }
}
