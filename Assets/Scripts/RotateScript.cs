using System.Collections;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    private IEnumerator Start()
    {
        var y = 0f;
        
        while (true)
        {
            yield return null;

            y += 90f * Time.deltaTime;

            transform.localRotation = Quaternion.Euler(0f, y, 0f);
        }
    }
}
