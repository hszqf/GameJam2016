// -----------------------------------------------------------------------------
//
//  Author : 	Duke Zhou
//  Data : 		2016/6/25
//
// -----------------------------------------------------------------------------
//

public class StaticItem : Item
{
    #region implemented abstract members of Item
    public override void MoveLeft(int distance)
    {
        return;
    }
    public override void MoveRight(int distance)
    {
        return;
    }
    public override void MoveUp(int distance)
    {
        return;
    }
    public override void MoveDown(int distance)
    {
        return;
    }
    public override void OnTick()
    {

    }

    public override bool canMove
    {
        get
        {
            return false;
        }
        set
        {
        }
    }
    #endregion
}