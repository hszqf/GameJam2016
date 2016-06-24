using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour {

    public int x;
    public int y;
    public virtual bool canMove
    {
        get;
        set;
    }

    public abstract void MoveLeft(int distance);
    public abstract void MoveRight(int distance);
    public abstract void MoveUp(int distance);
    public abstract void MoveDown(int distance);
    public abstract void OnTick();
}
