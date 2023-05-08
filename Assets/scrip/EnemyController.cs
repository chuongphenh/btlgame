using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public ThuyenController boat1;
    public ThuyenController boat2;
    public ThuyenController boat3;

    // Chỉ số màn chơi hiện tại
    private int currentLevel;

    // Biến thời gian giữa mỗi lần sinh ra thuyền
    private float spawnInterval = 4f;

    // Số lượng tối đa của từng loại thuyền theo màn chơi
    private int boat1MaxCount;
    private int boat2MaxCount;
    private int boat3MaxCount;

    // Số lượng thuyền đã sinh ra cho từng loại thuyền theo màn chơi
    private int boat1Spawned = 0;
    private int boat2Spawned = 0;
    private int boat3Spawned = 0;

    // Tốc độ của từng loại thuyền
    public float boat1Speed = 3.0f;
    public float boat2Speed = 2.0f;
    public float boat3Speed = 1.0f;

    // Thời gian cuối cùng mà thuyền được sinh ra
    private float lastSpawnTime = 0f;
    void Start()
    {
        currentLevel = 2;
    }
    void Update()
    {
        switch (currentLevel)
        {
            case 1:
                boat1MaxCount = 4;
                boat2MaxCount = 0;
                boat3MaxCount = 0;
                spawnInterval = 4f;
                break;
            case 2:
                boat1MaxCount = 5;
                boat2MaxCount = 2;
                boat3MaxCount = 1;
                spawnInterval = 3f;
                break;
            case 3:
                boat1MaxCount = 5;
                boat2MaxCount = 4;
                boat3MaxCount = 3;
                spawnInterval = 2f;
                break;
            default:
                // Nếu màn chơi không hợp lệ, dừng việc sinh thuyền
                return;
        }

        if (boat1Spawned < boat1MaxCount)
        {
            SpawnBoat(boat1);
        }
        else if (boat2Spawned < boat2MaxCount)
        {
            SpawnBoat(boat2);
        }
        else if (boat3Spawned < boat3MaxCount)
        {
            SpawnBoat(boat3);
        }

    }

    void SpawnBoat(ThuyenController boat)
    {
        if (Time.time > lastSpawnTime + spawnInterval)
        {
            float boatSpeed = 0.0f;

            if (boat == boat1)
            {
                boatSpeed = boat1Speed;
                boat1Spawned++;
            }
            else if (boat == boat2)
            {
                boatSpeed = boat2Speed;
                boat2Spawned++;
            }
            else if (boat == boat3)
            {
                boatSpeed = boat3Speed;
                boat3Spawned++;
            }

            // Tạo ra thuyền mới với tốc độ tương ứng
            Instantiate(boat, new Vector2(-11.6f, UnityEngine.Random.Range(-4.00f, -1.7f)), Quaternion.identity)
                .GetComponent<ThuyenController>().speed = boatSpeed;

            lastSpawnTime = Time.time;
        }
    }

    public void CompleteLevel()
    {
        currentLevel++;
        Start();
    }
}
