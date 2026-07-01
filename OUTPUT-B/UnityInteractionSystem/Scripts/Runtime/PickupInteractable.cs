using UnityEngine;

namespace Roots.Interaction
{
    public class PickupInteractable : Interactable
    {
        [Header("Pickup")]
        [SerializeField] private string itemName = "Item";
        [SerializeField] private AudioClip pickupSound;

        protected override void HandleInteraction(GameObject interactor)
        {
            Debug.Log($"Picked up {itemName}.");

            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }

            gameObject.SetActive(false);
        }
    }
}
