using UnityEngine;

public class AimScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var target = Camera.allCameras[0].transform; // main camera
        transform.LookAt(target);
    }
}
