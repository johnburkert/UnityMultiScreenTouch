using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class ActivateDisplayScript : MonoBehaviour
{
    private void Start()
    {
        var camera = GetComponent<Camera>();
        var index = camera.targetDisplay;

        if (index < Display.displays.Length)
        {
            Debug.Log($"Activating camera {index}");
            Display.displays[index].Activate();
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
