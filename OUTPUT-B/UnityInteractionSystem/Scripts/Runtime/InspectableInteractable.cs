using UnityEngine;

namespace Roots.Interaction
{
    public class InspectableInteractable : Interactable
    {
        [Header("Inspectable")]
        [SerializeField] private string inspectionText = "You inspect the object.";
        [SerializeField] private AudioClip interactionSound;

        protected override void HandleInteraction(GameObject interactor)
        {
            Debug.Log(inspectionText);

            if (interactionSound != null)
            {
                AudioSource.PlayClipAtPoint(interactionSound, transform.position);
            }
        }
    }
}
