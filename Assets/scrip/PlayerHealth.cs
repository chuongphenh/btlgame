using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    // quản lý lượng máu tối đa
    [SerializeField] int maxHealth;
    // lượng máu hiện tại của người chơi
    float currentHealth;

    public HealthBar healthBar;

    public ThuyenController thuyen1;
    public ThuyenController thuyen2;
    public ThuyenController thuyen3;
    //   public UnityEvent OnDate;

    //private void OnEnable()
    //{
    //       OnDate.AddListener(Death);
    //}

    //private void OnDisable()
    //{
    //       OnDate.RemoveListener(Death);

    //}

    // Start is called before the first frame update

    void Start()
    {

        currentHealth = maxHealth;
        healthBar.UpdateBar(currentHealth, maxHealth);
    }

    public void TakeDameage(float damage)
    {
        currentHealth -= damage;

        // kiểm tra nếu < 0 thì player đã chết

        healthBar.UpdateBar(currentHealth, maxHealth);

    }

    // nhân vân đã chết
    public void Death()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void truMau()
    {
        //for (int i = currentHealth; i > 0; i--)
        //{
        thuyen1.ischeck = ThuyenController.isDestroyed;

        if (thuyen1.ischeck == false)
        {
            TakeDameage(1f);
        }
        else
        {
            CancelInvoke("truMau");
        }
        //yield return new WaitForSeconds(2f);
        //}
    }



    void truMau2()
    {
        thuyen2.ischeck = ThuyenController.isDestroyed1;


        if (thuyen2.ischeck == false)
        {
            TakeDameage(2f);
        }
        else
        {
            CancelInvoke("truMau2");
        }
    }

    void truMau3()
    {
        thuyen3.ischeck = ThuyenController.isDestroyed2;

        if (thuyen3.ischeck == false)
        {
            TakeDameage(3f);
        }
        else
        {
            CancelInvoke("truMau3");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra nếu va chạm với thuyền
        ThuyenController boat = collision.gameObject.GetComponent<ThuyenController>();


        if (collision.gameObject.tag == "thuyen1")
        {
            ThuyenController.isDestroyed = false;
            InvokeRepeating("truMau", 0f, 2f);
        }
        else if (collision.gameObject.tag == "thuyen2")
        {
            ThuyenController.isDestroyed1 = false;
        
            InvokeRepeating("truMau2", 0f, 2f);
        }
        else if (collision.gameObject.tag == "thuyen3")
        {
            ThuyenController.isDestroyed2 = false;

            InvokeRepeating("truMau3", 0f, 2f);

        }
    }
}