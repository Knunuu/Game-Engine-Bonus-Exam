using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private int points = 1;

    public virtual void Eat()
    {
        Destroy(gameObject);
        SnakeMovement.Instance.GetFruit(points);
        FruitSpawner.Instance.SpawnFruit();
    }
}
