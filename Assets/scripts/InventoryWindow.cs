using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
    [SerializeField] RectTransform itemsPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Redraw()
    {
        for (int i = 0; i < targetInventory.inventoryItems.Count; i++)
        {
            var item = targetInventory.inventoryItems[i];
            
            GameObject icon = new GameObject("Icon");
            icon.AddComponent<Image>().sprite = item.Icon;
        }
    }
}
