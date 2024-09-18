using UnityEngine;
using Models;
using Views;

namespace Controllers
{
    public class InventoryController : MonoBehaviour
    {
        public InventoryView inventoryView;
        private PlayerInventory playerInventory;

        void Start()
        {
            playerInventory = new PlayerInventory();
            UpdateInventoryView();
        }

        public void AddItemToInventory(string item)
        {
            playerInventory.AddItem(item);
            UpdateInventoryView();
            // Opzionale: Aggiorna il punteggio del giocatore tramite un GameManager
            // GameManager.Instance.AddScore(10);
        }

        public void RemoveItemFromInventory(string item)
        {
            playerInventory.RemoveItem(item);
            UpdateInventoryView();
        }

        private void UpdateInventoryView()
        {
            inventoryView.UpdateInventory(playerInventory.GetItems());
        }
    }
}