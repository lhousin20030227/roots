using UnityEngine;
using TMPro;

namespace Roots.Interaction
{
    public class InteractionPromptUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI promptText;
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private float fadeDuration = 0.1f;

        private float targetAlpha = 0f;
        private float currentAlpha = 0f;

        private void Awake()
        {
            if (canvasGroup == null)
            {
                canvasGroup = GetComponent<CanvasGroup>();
            }

            if (canvasGroup == null)
            {
                canvasGroup = gameObject.AddComponent<CanvasGroup>();
            }

            canvasGroup.alpha = 0f;
        }

        public void ShowPrompt(string prompt)
        {
            if (promptText != null)
            {
                promptText.text = prompt;
            }

            targetAlpha = 1f;
        }

        public void HidePrompt()
        {
            targetAlpha = 0f;
        }

        private void Update()
        {
            if (Mathf.Abs(canvasGroup.alpha - targetAlpha) > 0.001f)
            {
                canvasGroup.alpha = Mathf.MoveTowards(canvasGroup.alpha, targetAlpha, Time.deltaTime / Mathf.Max(fadeDuration, 0.0001f));
            }
        }
    }
}
