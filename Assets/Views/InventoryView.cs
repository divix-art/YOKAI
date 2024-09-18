using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Views
{
    public class InventoryView : MonoBehaviour
    {
        public GameObject itemPrefab;
        public Transform inventoryPanel;

        public void UpdateInventory(List<string> items)
        {
            foreach (Transform child in inventoryPanel)
            {
                Destroy(child.gameObject);
            }

            foreach (string item in items)
            {
                GameObject newItem = Instantiate(itemPrefab, inventoryPanel);
                newItem.GetComponentInChildren<Text>().text = item;
            }
        }
    }
}