using UnityEngine;
using Roots.Interaction;

namespace Roots.Interaction.Examples
{
    public class PlayerInteractionExample : MonoBehaviour
    {
        [SerializeField] private InteractionManager interactionManager;

        private void Awake()
        {
            if (interactionManager == null)
            {
                interactionManager = GetComponent<InteractionManager>();
            }
        }

        private void Update()
        {
            if (interactionManager == null)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                interactionManager.Interact();
            }
        }
    }
}
