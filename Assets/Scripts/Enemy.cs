using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] protected float moveSpeed = 0.5f;
    protected int frameCount;

    public abstract void Move();
    public abstract void DestroyOnOutOfBounds();
}
