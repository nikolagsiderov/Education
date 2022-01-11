using UnityEngine;

public class FireScript : MonoBehaviour
{
    private void LateUpdate()
    {
        var current = gameObject.transform;
        var target = Camera.allCameras[0].transform; // main camera

        gameObject.transform.position = Vector3.Lerp(current.position, target.position, Time.time * 0.1f);
    }
}
