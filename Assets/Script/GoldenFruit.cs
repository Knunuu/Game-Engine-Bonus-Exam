using UnityEngine;

public class GoldenFruit : Fruit
{
    public override void Eat()
    {
        base.Eat();

        SnakeMovement.Instance.IncreaseSpeed();
    }
}
