using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_1 : MonoBehaviour
{
    public float flipInterval = 1f; // Thời gian giữa các lần Flip X
    private float timer; // Đếm thời gian
    private bool flipX = false; // Trạng thái Flip X

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Tính toán thời gian
        timer += Time.deltaTime;

        // Nếu đạt đến thời gian flipInterval
        if (timer >= flipInterval)
        {
            // Đảo ngược trạng thái Flip X
            flipX = !flipX;

            // Áp dụng Flip X cho sprite renderer
            spriteRenderer.flipX = flipX;

            // Đặt lại timer
            timer = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra nếu tag của đối tượng va chạm là "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player va chạm với nước");
            // Ngăn đối tượng Player đi qua nước
            other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
