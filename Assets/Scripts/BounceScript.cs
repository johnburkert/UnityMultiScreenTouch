using System.Collections;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    public float offset;
    public float speed = Mathf.PI;
    
    private IEnumerator Start()
    {
        var origin = transform.localPosition;
        var time = offset;
        
        while (true)
        {
            transform.localPosition = origin + new Vector3(0f, Mathf.Sin(time), 0f);
            
            yield return null;

            time += Time.deltaTime * speed;
        }
    }
}
