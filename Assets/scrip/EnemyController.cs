using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject[] Thuyen;
    //float T = 3f;
    //float timeCountDown1 = 0;
    //float timeCountDown2 = 0;

    //void Start()
    //{
    //    Instantiate(Thuyen[Random.Range(0, Thuyen.Length)], new Vector2(-11.6f, Random.Range(-4.00f, -1.7f)), Quaternion.identity);
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    timeCountDown1 += Time.deltaTime;
    //    if (timeCountDown1 >= T)
    //    {
    //        Instantiate(Thuyen[Random.Range(0, Thuyen.Length)], new Vector2(-11.8f, Random.Range(-4.00f, -1.7f)), Quaternion.identity);
    //        timeCountDown1 = 0;
    //    }
    //    if (timeCountDown2 >= 15)
    //    {
    //        if (T > 2)
    //        {
    //            T -= 0.5f;
    //        }
    //        timeCountDown2 = 0;
    //    }

    //}

    public ThuyenController boat1;
    public ThuyenController boat2;
    public ThuyenController boat3;
    private float lastSpawnTime = 0f;
    private float spawnInterval = 4f; // Khoảng thời gian giữa mỗi lần sinh ra thuyền

    void Update()
    {
        // Sinh ra thuyền ngẫu nhiên sau một khoảng thời gian
        if (Time.time > lastSpawnTime + spawnInterval)
        {
            int boatType = Random.Range(1, 4);
          
            switch (boatType)
            {
                case 1:

                    Instantiate(boat1, new Vector2(-11.6f, Random.Range(-4.00f, -1.7f)), Quaternion.identity);
                
                    break;
                case 2:
                    Instantiate(boat2, new Vector2(-11.6f, Random.Range(-4.00f, -1.7f)), Quaternion.identity);

                    break;
                case 3:
                    Instantiate(boat3, new Vector2(-11.6f, Random.Range(-4.00f, -1.7f)), Quaternion.identity);

                    break;
            }
            lastSpawnTime = Time.time;
        }
    }
}
