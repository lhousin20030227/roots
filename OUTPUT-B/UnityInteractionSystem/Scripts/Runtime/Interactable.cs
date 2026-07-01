using UnityEngine;
using UnityEngine.Events;

namespace Roots.Interaction
{
    [DisallowMultipleComponent]
    public abstract class Interactable : MonoBehaviour
    {
        [Header("Interaction")]
        [SerializeField] private string interactionPrompt = "Interact";
        [SerializeField] private InteractionType interactionType = InteractionType.Inspect;
        [SerializeField] private float interactionRange = 3f;
        [SerializeField] private int interactionPriority = 0;
        [SerializeField] private bool isEnabled = true;

        [Header("Events")]
        public UnityEvent onInteracted = new UnityEvent();

        public string InteractionPrompt => interactionPrompt;
        public InteractionType InteractionType => interactionType;
        public float InteractionRange => interactionRange;
        public int InteractionPriority => interactionPriority;
        public bool IsEnabled => isEnabled;

        public virtual bool CanInteract(GameObject interactor)
        {
            if (!isEnabled || !isActiveAndEnabled || interactor == null)
            {
                return false;
            }

            return Vector3.Distance(interactor.transform.position, transform.position) <= interactionRange;
        }

        public virtual string GetPrompt(GameObject interactor)
        {
            if (!CanInteract(interactor))
            {
                return string.Empty;
            }

            return $"[{interactionType}] {interactionPrompt}";
        }

        public virtual bool TryInteract(GameObject interactor)
        {
            if (!CanInteract(interactor))
            {
                return false;
            }

            HandleInteraction(interactor);
            onInteracted?.Invoke();
            return true;
        }

        protected abstract void HandleInteraction(GameObject interactor);

        public virtual void SetEnabled(bool value)
        {
            isEnabled = value;
        }
    }
}
