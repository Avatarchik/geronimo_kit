using UnityEngine;

public class BasicButtonController : MonoBehaviour
{
    public BasicButton[] Buttons;

    private void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            foreach (var button in Buttons)
            {
                button.OnClick += Button_OnClick;
            }
        }
    }

    private void Button_OnClick()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            foreach (var button in Buttons)
            {
                button.InitialState();
            }
        }
    }
}