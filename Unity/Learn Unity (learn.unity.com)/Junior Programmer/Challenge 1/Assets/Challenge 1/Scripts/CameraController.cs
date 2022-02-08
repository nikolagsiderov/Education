using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    void LateUpdate()
    {
        offset = new Vector3(25, 5, 10);
        transform.position = plane.transform.position + offset;

    }
}
