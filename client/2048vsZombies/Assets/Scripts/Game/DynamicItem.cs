// -----------------------------------------------------------------------------
//
//  Author : 	Duke Zhou
//  Data : 		2016/6/25
//
// -----------------------------------------------------------------------------
//
using UnityEngine;

public class DynamicItem : Item
{
    #region implemented abstract members of Item
    public override void MoveLeft(int distance)
    {
        gameObject.transform.Translate(Vector3.left * distance);
    }
    public override void MoveRight(int distance)
    {
        gameObject.transform.Translate(Vector3.right * distance);
    }
    public override void MoveUp(int distance)
    {
        gameObject.transform.Translate(Vector3.forward * distance);
    }
    public override void MoveDown(int distance)
    {
        gameObject.transform.Translate(Vector3.back * distance);
    }
    public override void OnTick()
    {
    }
    #endregion
}