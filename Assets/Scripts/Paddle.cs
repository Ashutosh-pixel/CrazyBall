using UnityEngine;

public class Paddle : MonoBehaviour
{
    Vector2 touch;
    Rigidbody2D rb;

    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            touch = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touch.x < 0)
            {
                // transform.Translate(touch.x * speed, 0, 0);
                rb.velocity = Vector2.left * speed;
            }
            else
            {
                // transform.Translate(touch.x * speed, 0, 0);
                rb.velocity = Vector2.right * speed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
