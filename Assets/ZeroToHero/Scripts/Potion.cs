using UnityEngine;
using System.Collections;

public class Potion : MonoBehaviour, IItemComponent {

    public void UseItem(ItemData item)
    {
        Debug.Log("using: " + item.itemName);
    }

}
