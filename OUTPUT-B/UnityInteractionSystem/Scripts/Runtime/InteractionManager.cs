using UnityEngine;

namespace Roots.Interaction
{
    [DisallowMultipleComponent]
    public class InteractionManager : MonoBehaviour
    {
        [Header("Detection")]
        [SerializeField] private Camera playerCamera;
        [SerializeField] private LayerMask detectionMask = ~0;
        [SerializeField] private float maxInteractionDistance = 3f;
        [SerializeField] private KeyCode interactionKey = KeyCode.E;

        [Header("UI")]
        [SerializeField] private InteractionPromptUI promptUI;

        private Interactable currentInteractable;
        private GameObject interactor;

        public Interactable CurrentInteractable => currentInteractable;
        public bool HasCurrentInteractable => currentInteractable != null;
        public event System.Action<Interactable> OnInteractableChanged;

        private void Awake()
        {
            if (playerCamera == null)
            {
                playerCamera = Camera.main;
            }

            interactor = gameObject;
        }

        private void Update()
        {
            UpdateFocus();

            if (Input.GetKeyDown(interactionKey))
            {
                Interact();
            }
        }

        private void UpdateFocus()
        {
            Interactable newInteractable = FindFocusedInteractable();

            if (newInteractable != currentInteractable)
            {
                currentInteractable = newInteractable;
                OnInteractableChanged?.Invoke(currentInteractable);
            }

            if (promptUI != null)
            {
                if (currentInteractable != null && currentInteractable.CanInteract(gameObject))
                {
                    promptUI.ShowPrompt(currentInteractable.GetPrompt(gameObject));
                }
                else
                {
                    promptUI.HidePrompt();
                }
            }
        }

        private Interactable FindFocusedInteractable()
        {
            Ray ray = new Ray(
                playerCamera != null ? playerCamera.transform.position : transform.position,
                playerCamera != null ? playerCamera.transform.forward : transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, maxInteractionDistance, detectionMask))
            {
                Interactable candidate = hit.collider.GetComponentInParent<Interactable>();
                if (candidate != null && candidate.CanInteract(gameObject))
                {
                    return candidate;
                }
            }

            Collider[] colliders = Physics.OverlapSphere(transform.position, maxInteractionDistance, detectionMask);
            Interactable best = null;

            foreach (Collider collider in colliders)
            {
                Interactable candidate = collider.GetComponentInParent<Interactable>();
                if (candidate == null || !candidate.CanInteract(gameObject))
                {
                    continue;
                }

                if (best == null || candidate.InteractionPriority > best.InteractionPriority)
                {
                    best = candidate;
                }
            }

            return best;
        }

        public void Interact()
        {
            if (currentInteractable == null || !currentInteractable.CanInteract(gameObject))
            {
                return;
            }

            currentInteractable.TryInteract(gameObject);

            if (promptUI != null)
            {
                promptUI.HidePrompt();
            }
        }
    }
}
