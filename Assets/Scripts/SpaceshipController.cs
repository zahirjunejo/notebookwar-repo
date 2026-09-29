using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public GameObject bullet;

    private float timeBetweenShots = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenShots += Time.deltaTime;
        if (Input.GetKeyDown((KeyCode.RightArrow)))
        {
            transform.Translate(moveSpeed * Vector2.right);
        }

        if (Input.GetKeyDown((KeyCode.LeftArrow)))
        {
            transform.Translate(moveSpeed * Vector2.left);    
        }

        if (Input.GetKeyDown(KeyCode.Space) && timeBetweenShots > 1.0f)
        {
            timeBetweenShots = 0;
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }

        if (transform.position.x < -4.5)
        {
            transform.Translate(Vector2.right);
        }

        if (transform.position.x > 4.5)
        {
            transform.Translate(Vector2.left);
        }
    }
}
