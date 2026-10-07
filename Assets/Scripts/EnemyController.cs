using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
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
        throw new System.NotImplementedException();
    }
}
