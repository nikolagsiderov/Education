using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 30;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
