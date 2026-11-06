using UnityEngine;

public class FruitFactory : MonoBehaviour
{
    [SerializeField] protected Fruit fruit;

    public virtual Fruit SpawnFruit(Transform location)
    {
        Fruit instance = Instantiate(fruit.gameObject, location.position, location.rotation).GetComponent<Fruit>();
        return instance;
    }
}
