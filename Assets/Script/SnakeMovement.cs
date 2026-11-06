using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public static SnakeMovement Instance  { get; private set; }
    private Vector2 lastDirection;
    [SerializeField] private float speed = 2;
    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            lastDirection = new Vector2(0, 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            lastDirection = new Vector2(0, -1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            lastDirection = new Vector2(-1, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            lastDirection = new Vector2(1, 0);
        }

        transform.Translate(lastDirection * speed * Time.deltaTime, Space.World);
    }

    public void GetFruit(int points)
    {
        score += points;

        Debug.Log("Score: " + score);
    }

    public void IncreaseSpeed()
    {
        speed++;
    }

    private void Die()
    {
        gameObject.SetActive(false);
        Debug.Log("You Lose");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Die();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            collision.gameObject.GetComponent<Fruit>().Eat();
        }
    }
}
