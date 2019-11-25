using System;
using System.Collections;
using GeronimoKit.UI.Panels.Basic;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Panels
{
    public class SplashPanel : BasicPanel
    {
        [Header("Components")]
        [SerializeField] private Button _btnTap = default;
        [SerializeField] private Text _txtTap = default;
        [SerializeField] private Image _imgIcon = default;
        [SerializeField] private Image[] _line = default;

        private int _countLine = 0;

        protected override void Start()
        {
            base.Start();

            _btnTap.onClick.AddListener(() =>
            {
                _txtTap.gameObject.SetActive(false);
                _imgIcon.gameObject.SetActive(false);
                StartCoroutine(AnimStartAsync());
            });

            SetActive(true);
        }

        private IEnumerator AnimStartAsync()
        {
            foreach (var line in _line)
            {
                yield return new WaitForSeconds(0.05f);
                StartCoroutine(AnimAsync(line));
            }
        }

        private IEnumerator AnimAsync(Image line)
        {
            while (Math.Abs(line.fillAmount - 1) > 0.0001)
            {
                yield return new WaitForSeconds(0.01f * Time.deltaTime);
                line.fillAmount += 0.075f;
            }

            yield return new WaitForSeconds(0.50f);
            line.fillOrigin = 1;

            while (Math.Abs(line.fillAmount) > 0.0001)
            {
                yield return new WaitForSeconds(0.01f * Time.deltaTime);
                line.fillAmount -= 0.075f;
            }

            _countLine++;

            if (_countLine == _line.Length)
            {
                LoadScene();
            }
        }

        private void LoadScene()
        {
            ScenesManager.Instance.LoadScene("Main");
        }
    }
}
