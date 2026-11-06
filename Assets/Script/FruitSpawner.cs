using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public static FruitSpawner Instance  { get; private set; }
    private FruitFactory selectedFactory;
    [SerializeField] private FruitFactory regular, golden;
    [SerializeField] private float bounds = 5f;

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

    public void SpawnFruit()
    {
        if (SnakeMovement.Instance.GetScore() % 5 == 0)
        {
            selectedFactory = golden;
        }
        else
        {
            selectedFactory = regular;
        }

        Vector3 randomLocation = new Vector3(Random.Range(-bounds, bounds), Random.Range(-bounds, bounds), 0f);
        

        selectedFactory.SpawnFruit(randomLocation);
    }
}
