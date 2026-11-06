using UnityEngine;

public class GoldenFruitFactory : FruitFactory
{
    public override Fruit SpawnFruit(Transform location)
    {
        Debug.Log("SPAWNING GOLDEN FRUIT");
        Fruit instance = Instantiate(fruit.gameObject, location.position, location.rotation).GetComponent<Fruit>();
        return instance;
    }
}
