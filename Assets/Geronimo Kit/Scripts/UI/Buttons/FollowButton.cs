using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Buttons
{
    public class FollowButton : MonoBehaviour
    {
        [SerializeField] private string _url = default;

        private void Start()
        {
            var button = gameObject.GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(() => { Application.OpenURL(_url); });
            }
        }
    }
}