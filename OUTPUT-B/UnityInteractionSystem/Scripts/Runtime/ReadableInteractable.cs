using UnityEngine;

namespace Roots.Interaction
{
    public class ReadableInteractable : Interactable
    {
        [Header("Readable")]
        [SerializeField] private string documentTitle = "Document";
        [SerializeField] private string documentText = "This document contains important information.";
        [SerializeField] private AudioClip readSound;

        protected override void HandleInteraction(GameObject interactor)
        {
            Debug.Log($"Reading {documentTitle}: {documentText}");

            if (readSound != null)
            {
                AudioSource.PlayClipAtPoint(readSound, transform.position);
            }
        }
    }
}
