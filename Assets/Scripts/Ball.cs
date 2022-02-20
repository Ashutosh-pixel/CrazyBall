using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float Amount;
    [SerializeField] GameObject game_Object;
    [SerializeField] GameObject ScoreObject;
       // bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ScoreObject.SetActive(false);
    }

    void Update()
    {
        RandomBall();
        if(Input.anyKeyDown){
            game_Object.SetActive(false);
            ScoreObject.SetActive(true);
        }
    }
    void RandomBall()
    {
        Vector2 random = new Vector2(Random.Range(-3.5f, 3.5f), 4.36f);
        // Debug.Log(random);
        rb.AddForce(random * Amount * Time.deltaTime, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Restart")
        {
            RestartGame.Restart();
            ScoreManager.Score = 0;
            game_Object.SetActive(true);
            ScoreObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Paddle")
        {
            ScoreManager.Score += 1;
        }
    }
}

