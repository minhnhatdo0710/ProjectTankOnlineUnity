using System;
using System.Collections;
using System.Collections.Generic;
using Entity;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Bullet Bullet { get; set; }

    public int MaxRange { get; set; }
    // Update is called once per frame
    private void Update()
    {
        DestroyAfterRange();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Nếu đụng vào brick thì destroy brick và đạn
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
        //Nếu đụng vào steel thì destroy đạn
        if (collision.gameObject.CompareTag("Steel"))
        {
            Destroy(gameObject);
        }

        //Nếu đụng vào boundary thì destroy đạn
        if (collision.gameObject.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }

    private void DestroyAfterRange()
    {
        var currentPos = gameObject.transform.position;
        var initPos = Bullet.InitialPosition;
        switch (Bullet.Direction)
        {
            case Direction.Down:
                if (initPos.y - MaxRange >= currentPos.y)
                {
                    Destroy(gameObject);
                }

                break;
            case Direction.Up:
                if (initPos.y + MaxRange <= currentPos.y)
                {
                    Destroy(gameObject);
                }

                break;
            case Direction.Left:
                if (initPos.x - MaxRange >= currentPos.x)
                {
                    Destroy(gameObject);
                }

                break;
            case Direction.Right:
                if (initPos.x + MaxRange <= currentPos.x)
                {
                    Destroy(gameObject);
                }

                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}