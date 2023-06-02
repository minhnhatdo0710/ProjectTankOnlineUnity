using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra nếu đối tượng va chạm có tag là "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Ngăn đối tượng Player đi qua đá
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        // Kiểm tra nếu đối tượng va chạm là đạn của Player
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            // Ngăn đạn bắn xuyên qua đá
            Destroy(collision.gameObject);
        }
    }
}
