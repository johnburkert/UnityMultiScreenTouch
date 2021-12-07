
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickScript : MonoBehaviour
{
    public Canvas canvas;
    public Text outputText;
    public Text buttonText;

    private int _clicks;
    
    private void Start()
    {
        buttonText.text = $"{canvas.worldCamera.name} Button";
    }
    
    public void OnClick()
    {
        outputText.text = $"{buttonText.text} was clicked! ({++_clicks})";
    }
}
