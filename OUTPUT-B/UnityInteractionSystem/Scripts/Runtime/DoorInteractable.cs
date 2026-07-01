using UnityEngine;

namespace Roots.Interaction
{
    public class DoorInteractable : Interactable
    {
        [Header("Door")]
        [SerializeField] private Transform doorHinge;
        [SerializeField] private float openAngle = 90f;
        [SerializeField] private float openDuration = 0.75f;
        [SerializeField] private bool isOpen;

        private Quaternion closedRotation;
        private Quaternion openRotation;
        private float openingTimer;
        private bool isAnimating;

        private void Awake()
        {
            if (doorHinge == null)
            {
                doorHinge = transform;
            }

            closedRotation = doorHinge.localRotation;
            openRotation = Quaternion.Euler(doorHinge.localEulerAngles.x, doorHinge.localEulerAngles.y + openAngle, doorHinge.localEulerAngles.z);
        }

        private void Update()
        {
            if (!isAnimating)
            {
                return;
            }

            openingTimer += Time.deltaTime;
            float t = Mathf.Clamp01(openingTimer / openDuration);
            doorHinge.localRotation = Quaternion.Slerp(isOpen ? openRotation : closedRotation, isOpen ? closedRotation : openRotation, t);

            if (t >= 1f)
            {
                isAnimating = false;
            }
        }

        protected override void HandleInteraction(GameObject interactor)
        {
            if (isAnimating)
            {
                return;
            }

            isOpen = !isOpen;
            openingTimer = 0f;
            isAnimating = true;
            Debug.Log(isOpen ? "Door opened." : "Door closed.");
        }
    }
}
