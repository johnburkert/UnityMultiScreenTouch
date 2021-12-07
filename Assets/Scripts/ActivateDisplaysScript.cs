using System.Linq;
using UnityEngine;

public class ActivateDisplaysScript : MonoBehaviour
{
    private void Start()
    {
        foreach (var display in Display.displays.Skip(1))
        {
            display.Activate();
        }
    }
}
