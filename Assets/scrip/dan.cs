using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Animations;

public class dan : MonoBehaviour
{
    //    AudioSource audio;
    //    public AudioClip destroy;
    //    bool isMoving = true;
    //    int hpHtuyenNho = 1;
    //    int hpThuyenVua = 2;
    //    // Start is called before the first frame update
    //    void Start()
    //    {
    //        audio = GetComponent<AudioSource>();

    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {

    //    }
    //    void OnCollisionEnter2D(Collision2D coll)
    //    {
    ////audio.PlayOneShot(tiengNo);
    //            // audio.PlayOneShot(destroy);
    //        if (coll.gameObject.tag == "thuyen")
    //        {
    //            hpHtuyenNho = hpHtuyenNho - 1;
    //            Destroy(this.gameObject);
    //            if (hpHtuyenNho <= 0)
    //            {
    //                isMoving = false;
    //                Score.score = Score.score + 10;
    //                Destroy(coll.gameObject);
    //                hpHtuyenNho = 1;
    //            }

    //        }
    //        if (coll.gameObject.tag == "thuyenVua")
    //        {
    //            hpThuyenVua = hpThuyenVua - 1;
    //            Destroy(this.gameObject);
    //            if (hpThuyenVua <= 0)
    //            {
    //                isMoving = false;
    //                Score.score = Score.score + 20;
    //                Destroy(coll.gameObject);
    //                hpThuyenVua = 2;
    //            }
    //        }
    //    }

    public int damage; // Sát thương của viên đạn
    
    private void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra nếu va chạm với thuyền
        ThuyenController boat = collision.gameObject.GetComponent<ThuyenController>();
        if (collision.gameObject.tag == "thuyen1" )
        {
                    Score.score = Score.score + 10;
            boat.TakeDamage(damage); // Gây sát thương cho thuyền
            Destroy(gameObject); // Xoá viên đạn
        }
       else if ( collision.gameObject.tag == "thuyen2")
        {
            Score.score = Score.score + 20;
            boat.TakeDamage(damage); // Gây sát thương cho thuyền
            Destroy(gameObject); // Xoá viên đạn
        }
        else if (collision.gameObject.tag == "thuyen3")
        {
            Score.score = Score.score + 30;
            boat.TakeDamage(damage); // Gây sát thương cho thuyền
            Destroy(gameObject); // Xoá viên đạn
        }
        //    if (boat != null)
        //{
        //    boat.TakeDamage(damage); // Gây sát thương cho thuyền
        //    Destroy(gameObject); // Xoá viên đạn
        //}
    }
}

