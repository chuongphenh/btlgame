using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class daiBac : MonoBehaviour
{

    //public Transform target;
    // Góc xoay tối đa của cung tên
    //public float maxRotationAngle = 90f;
    public GameObject dan;
    public Transform noiTaoDan; // nơi tạo vị trí tên đầu nỏ
    public float tocDoBan = 1f;  // tốc độ bắn
    public float lucCuaDan;  // lực của tên

    private float tocdoban;
    AudioSource audio;
    public AudioClip fire;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        quayNo();
        tocdoban -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && tocdoban < 0)
        {
            banTen();
        }
    }

    void quayNo()
    {
        audio = GetComponent<AudioSource>();

        //Lấy vị trí hiện tại của chuột trong không gian thế giới
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Tính toán vị trí của chuột so với cung tên
        Vector3 direction = mousePosition - transform.position;

        // Tính toán góc giữa hướng của chuột và hướng hiện tại của cung tên
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Giới hạn góc xoay trong khoảng -180 đến 180 độ
        //	  angle = Mathf.Clamp(angle, 90f, 280f); 

        // Tạo ra quay đối tượng dựa trên góc mới tính toán
        Quaternion rotation = Quaternion.Euler(0, 0, angle);

        // Áp dụng quay đối tượng
        transform.rotation = rotation;
    }
    void banTen()
    {
        tocdoban = tocDoBan;
        GameObject muiTen = Instantiate(dan, noiTaoDan.position, Quaternion.identity);
        Rigidbody2D rb = muiTen.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * lucCuaDan, ForceMode2D.Impulse);
        audio.PlayOneShot(fire);

    }

}