using UnityEngine;

namespace GeronimoKit.UI.Canvas
{
    public class BlinkCanvas : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup = default;

        private float _alphaMin = 0.25f;
        private float _alphaMax = 1.0f;
        private float _timer = 0.0f;
        private float _speed = 1.0f;

        private void Update()
        {
            _canvasGroup.alpha = Mathf.Lerp(_alphaMin, _alphaMax, _timer);
            _timer += _speed * Time.deltaTime;

            if (_timer > 1.0f)
            {
                var temp = _alphaMax;
                _alphaMax = _alphaMin;
                _alphaMin = temp;
                _timer = 0.0f;
            }
        }
    }
}