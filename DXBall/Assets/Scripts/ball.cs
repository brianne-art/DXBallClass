using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    public float speed;
    public Vector2 direction;

    public int brickCount = 0;

    public scoreScript score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized; //(1,1)

        score = GameObject.FindGameObjectWithTag("logic").GetComponent<scoreScript>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = direction * speed;

    }
    void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("paddle"))
            direction.y = -direction.y;

        else if (collison.gameObject.CompareTag("brick"))
        {
            direction.y = -direction.y;
            Destroy(collison.gameObject);
            brickCount = brickCount + 1;
            Debug.Log("Bricks destroyed: " + brickCount);
            score.addScore(1); // 1 means score happened
        }

        else if (collison.gameObject.CompareTag("sidewall"))
            direction.x = -direction.x;

        else if (collison.gameObject.CompareTag("topwall"))
            direction.y = -direction.y;

        else if (collison.gameObject.CompareTag("bottomwall"))
            score.addScore(0); // 0 means game over
            Debug.Log("Game over");
            gameObject.SetActive(false);
           
    }
}
