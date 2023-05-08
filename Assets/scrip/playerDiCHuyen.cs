using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDiCHuyen : MonoBehaviour
{

	 float moveDistance = 0.2f; // khoảng cách di chuyển
	 float moveSpeed = 2f; // tốc độ di chuyển
	 SpriteRenderer sprite;

	private bool moveLeft = true; // biến kiểm tra hướng di chuyển
								  // Start is called before the first frame update
	void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
		MovePlayer();
	}

	void MovePlayer()
	{
		if (moveLeft)
		{
			transform.Translate(Vector3.left * moveDistance * Time.deltaTime * moveSpeed); // di chuyển sang trái
		//	facingRight = !facingRight;
			
		}
		else
		{
			transform.Translate(Vector3.right * moveDistance * Time.deltaTime * moveSpeed); // di chuyển sang phải
			//facingRight = !facingRight;
			
		}

		// kiểm tra nếu player đã đi đến khoảng cách cần di chuyển thì đổi hướng di chuyển
		if (transform.position.x <= 9.5f && moveLeft)
		{
			moveLeft = false;
			//Vector3 scale = transform.localScale;
			//scale.x *= -1;
			//transform.localScale = scale;
			sprite.flipX = false;

		}
		else if (transform.position.x >= 11.5f && !moveLeft)
		{
			moveLeft = true;
			//Vector3 scale = transform.localScale;
			//scale.x *= -1;
			//transform.localScale = scale;
			sprite.flipX = true;
		}
	}

}
