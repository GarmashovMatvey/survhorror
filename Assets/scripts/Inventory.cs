using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Item> StartItems = new List<Item>();
    public List<Item> inventoryItems = new List<Item>();
    void Start()
    {
        for (int i = 0; i < StartItems.Count; i++)
        {
            AddItem(StartItems[i]);
        }
    }

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
    }
}
