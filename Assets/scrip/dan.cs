using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Animations;

public class dan : MonoBehaviour
{
    public AudioClip hitSound;
    public int damage; // Sát thương của viên đạn
    
    private void Update()
    {
       if(transform.position.y < -9f)
        {
            Destroy(gameObject);
        }    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra nếu va chạm với thuyền
        ThuyenController boat = collision.gameObject.GetComponent<ThuyenController>();
        if (collision.gameObject.tag == "thuyen1" )
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
            boat.TakeDamage(damage); // Gây sát thương cho thuyền
          
            Destroy(gameObject); // Xoá viên đạn
          


        }
        else if ( collision.gameObject.tag == "thuyen2")
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);

            boat.TakeDamage(damage); // Gây sát thương cho thuyền
            Destroy(gameObject); // Xoá viên đạn
        }
        else if (collision.gameObject.tag == "thuyen3")
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
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

