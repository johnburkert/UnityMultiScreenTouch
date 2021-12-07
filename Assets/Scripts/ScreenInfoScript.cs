using UnityEngine;

public class ScreenInfoScript : MonoBehaviour
{
    private Vector2 _mouseCoords;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mouseCoords = Input.mousePosition;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    
    private void OnGUI()
    {
        var rect = new Rect(10, 10, 400, 40);
        
        GUI.Label(rect, $"Display: {Screen.currentResolution}");

        rect.y += rect.height;
        
        GUI.Label(rect, $"Screen: {Screen.width} x {Screen.height}");

        rect.y += rect.height;
        
        GUI.Label(rect, $"Mouse: {_mouseCoords.x} x {_mouseCoords.y}");
    }
}
