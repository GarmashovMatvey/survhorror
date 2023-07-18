using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
    [SerializeField] Transform Window;
    private List<GameObject> slots = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < targetInventory.inventoryItems.Count; i++)
        {
            var item = targetInventory.inventoryItems[i];
            
            GameObject icon = new GameObject("Icon");
            icon.AddComponent<SpriteRenderer>().sprite = item.Icon;
            icon.transform.SetParent(Window);
        }
    }

    // Update is called once per frame
    void Redraw()
    {

    }
}
