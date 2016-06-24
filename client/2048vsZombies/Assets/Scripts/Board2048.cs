using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SleepyHippo.Util;

public class Board2048 : MonoBehaviour {

    public const int WIDTH = 4;

    public GameObject TowerTemplate;

    /// <summary>
    /// -1：不能走
    /// 0：空
    /// 2,4,8,16……：power
    /// 原点在左下角：
    /// 12 13 14 15
    ///  8  9 10 11
    ///  4  5  6  7
    ///  0  1  2  3
    /// </summary>
    public int[] typeMap = new int[16];

    /// <summary>
    /// 显示组件
    /// </summary>
    public Dictionary<int, Item> itemMap = new Dictionary<int, Item>();

    void Awake()
    {
        Messenger.AddListener(MessageConst.INPUT_LEFT, DoLeft);
        Messenger.AddListener(MessageConst.INPUT_RIGHT, DoRight);
        Messenger.AddListener(MessageConst.INPUT_UP, DoUp);
        Messenger.AddListener(MessageConst.INPUT_DOWN, DoDown);
    }

    Tower GenerateTower()
    {
        Tower tower = GameObjectPool.Instance.Spawn(TowerTemplate, 16, true).GetComponent<Tower>();
        int choice = Random.Range(1, 3);
        switch(choice)
        {
            case 1:
                tower.power = 2;
                break;
            case 2:
                tower.power = 4;
                break;
            case 3:
                tower.power = 8;
                break;
        }
        return tower;
    }

    void PutItemAt(Item item, int index)
    {
        if(itemMap.ContainsKey(index))
        {
            Debug.LogError("Index: " + index + " has item: " + itemMap[index]);
            return;
        }
        itemMap[index] = item;
        item.x = CommonUtil.GetX(index, WIDTH);
        item.y = CommonUtil.GetY(index, WIDTH);
        item.gameObject.transform.position = new Vector3(item.x, 0, item.y);
    }

    void DoLeft()
    {
        Debug.Log("Left");
    }

    void DoRight()
    {
        Debug.Log("Right");
    }

    void DoUp()
    {
        Debug.Log("Up");
    }

    void DoDown()
    {
        Debug.Log("Down");
        Tower tower = GenerateTower();
        PutItemAt(tower, 0);
    }
}
