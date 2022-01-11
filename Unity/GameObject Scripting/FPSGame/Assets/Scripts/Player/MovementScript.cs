using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Change position
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        // Change rotation
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(new Vector3(0, -speed * Time.deltaTime * 10, 0));
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0, speed * Time.deltaTime * 10, 0));
    }
}
