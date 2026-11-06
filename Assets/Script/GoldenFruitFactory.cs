using UnityEngine;

public class GoldenFruitFactory : FruitFactory
{
    public override Fruit SpawnFruit(Vector3 location)
    {
        Debug.Log("SPAWNING GOLDEN FRUIT");
        Fruit instance = Instantiate(fruit.gameObject,location, Quaternion.identity).GetComponent<Fruit>();
        return instance;
    }
}
