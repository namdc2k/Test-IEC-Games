using System.Collections;
using System.Collections.Generic;
using Controllers;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }
    private Board _board;
    public eNormalType ItemType;
    
    public void SetBoard(Board board)
    {
        _board = board;
    }
    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    public override void SetView()
    {
        string prefabname = GetPrefabName();

        if (!string.IsNullOrEmpty(prefabname))
        {
            //GameObject prefab = Resources.Load<GameObject>(prefabname);
            GameObject prefab = PoolItemNormal.SpawnItem();
            prefab.name = prefabname;
            if (prefab)
            {
                View = prefab.transform;
                View.GetComponent<SpriteRenderer>().sprite = DataContainerManager.GetNormalItem((int)ItemType).texture;
            }
        }
    }

    protected override string GetPrefabName()
    {
        string prefabname = string.Empty;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_ONE;
                break;
            case eNormalType.TYPE_TWO:
                prefabname = Constants.PREFAB_NORMAL_TYPE_TWO;
                break;
            case eNormalType.TYPE_THREE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_THREE;
                break;
            case eNormalType.TYPE_FOUR:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FOUR;
                break;
            case eNormalType.TYPE_FIVE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FIVE;
                break;
            case eNormalType.TYPE_SIX:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SIX;
                break;
            case eNormalType.TYPE_SEVEN:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SEVEN;
                break;
        }

        return prefabname;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }

    protected override void DestroyView()
    {
        PoolItemNormal.DeSpawnItem(View.gameObject);
        _board.RemoveNormalItem(this);
        View = null;
    }
}