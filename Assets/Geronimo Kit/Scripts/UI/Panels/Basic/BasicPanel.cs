using UnityEngine;

namespace GeronimoKit.UI.Panels.Basic
{
    public class BasicPanel : MonoBehaviour
    {
        [SerializeField] private GameObject _root = default;

        private CanvasGroup _canvasGroup;

        private void Awake()
        {
            _canvasGroup = _root.AddComponent<CanvasGroup>();
            _canvasGroup.alpha = 0.0f;
        }

        protected virtual void Start()
        {

        }

        public void SetActive(bool value)
        {
            _root.SetActive(value);
            StopAllCoroutines();

            StartCoroutine(value
                ? Utils.FadeIn(_canvasGroup, 1.0f, 0.5f)
                : Utils.FadeOut(_canvasGroup, 0.0f, 0.5f));
        }
    }
}