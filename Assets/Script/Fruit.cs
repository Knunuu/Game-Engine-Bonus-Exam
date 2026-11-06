using UnityEngine;

public class Fruit : MonoBehaviour
{
    protected int points = 1;

    public virtual void Eat()
    {
        Destroy(gameObject);
        SnakeMovement.Instance.GetFruit();
    }
}
