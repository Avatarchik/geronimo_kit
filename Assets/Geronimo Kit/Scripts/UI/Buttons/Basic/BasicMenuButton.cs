using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GeronimoKit.UI.Buttons.Basic
{
    public class BasicMenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        [SerializeField] private Image _imgLine = default;

        private float _widthButton;
        private float _heightButton;
        private float _widthLine;
        private float _heightLine;

        private float _velocity = 0.0F;
        private const float TIME_ANIM = 0.1F;
        private bool _enter = false;
        private bool _exit = false;

        public event Action OnClick;

        protected virtual void Start()
        {
            _widthButton = GetComponent<RectTransform>().rect.width;
            _heightButton = GetComponent<RectTransform>().rect.height;
            _widthLine = _imgLine.GetComponent<RectTransform>().rect.width;
            _heightLine = _imgLine.GetComponent<RectTransform>().rect.height;
        }

        private void Update()
        {
            if (_enter)
            {
                GoAnim();
            }

            if (_exit)
            {
                BackAnim();
            }
        }

        public void InitialState()
        {
            _enter = false;
            _exit = true;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_WEBGL
            _enter = true;
            _exit = false;
#endif
        }

        public void OnPointerExit(PointerEventData eventData)
        {
#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_WEBGL
            _enter = false;
            _exit = true;
#endif
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _enter = true;
            _exit = false;

            StartCoroutine(OnClickAsync());
        }

        private void GoAnim()
        {
            var targetLine = _imgLine.GetComponent<RectTransform>().rect.width;
            var width = Mathf.SmoothDamp(targetLine, _widthButton, ref _velocity, TIME_ANIM);

            _imgLine.rectTransform.sizeDelta = new Vector2(width, _heightButton);
        }

        private void BackAnim()
        {
            var targetLine = _imgLine.GetComponent<RectTransform>().rect.width;
            var width = Mathf.SmoothDamp(targetLine, _widthLine, ref _velocity, TIME_ANIM);

            _imgLine.rectTransform.sizeDelta = new Vector2(width, _heightLine);
        }

        private IEnumerator OnClickAsync()
        {
            yield return new WaitForSeconds(TIME_ANIM + 0.12f);
            OnClick?.Invoke();
        }

        private void OnEnable()
        {
            _enter = false;
            _exit = true;
        }
    }
}