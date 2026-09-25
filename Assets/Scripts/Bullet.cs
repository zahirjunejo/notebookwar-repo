using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [Header("Movement")]    
    [SerializeField] protected float moveSpeed = 0.5f;
    [SerializeField] protected int frameCount = 0;
    [SerializeField] protected GameObject explosion;
    
    public abstract void Move();
    public abstract void DestroyOnOutOfBounds();
    public abstract void DestroyOnCollision(Collider2D collision);
}
