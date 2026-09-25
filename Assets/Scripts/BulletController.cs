using UnityEngine;

public class BulletController : Bullet
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyOnOutOfBounds();
    }

    public override void Move()
    {
        frameCount++;
        if (frameCount > 30)
        {
            transform.Translate(moveSpeed * Vector2.up);
            frameCount = 0;
        }
    }

    public override void DestroyOnOutOfBounds()
    {
        if (transform.position.y > 10 || transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    public override void DestroyOnCollision(Collider2D collision)
    {
        throw new System.NotImplementedException();
    }
}
