using UnityEngine;

public class FruitFactory : MonoBehaviour
{
    [SerializeField] protected Fruit fruit;

    public virtual Fruit SpawnFruit(Vector3 location)
    {
        Fruit instance = Instantiate(fruit.gameObject, location, Quaternion.identity).GetComponent<Fruit>();
        return instance;
    }
}
