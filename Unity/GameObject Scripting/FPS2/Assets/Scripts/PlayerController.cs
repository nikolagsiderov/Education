using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 3;
    public float jump = 7;
    public GameObject mainCamera;

    private Rigidbody rigidBody;
    private Vector3 movingVectorHorizontal;
    private Vector3 movingVectorVertical;
    private bool isInAir = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("w"))
            movingVectorVertical = transform.forward * speed;
        else if (Input.GetKey("down") || Input.GetKey("s"))
            movingVectorVertical = -transform.forward * speed;

        if (Input.GetKey("right") || Input.GetKey("d"))
            movingVectorHorizontal = transform.right * speed;
        else if (Input.GetKey("left") || Input.GetKey("a"))
            movingVectorHorizontal = -transform.right * speed;

        if ((Input.GetKey("up") || Input.GetKey("w") || Input.GetKey("w") || Input.GetKey("s")) == false)
            movingVectorVertical = Vector3.zero;
        if ((Input.GetKey("left") || Input.GetKey("a") || Input.GetKey("right") || Input.GetKey("d")) == false)
            movingVectorHorizontal = Vector3.zero;
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && isInAir.Equals(false))
        {
            rigidBody.velocity = new Vector3(0, jump, 0);
            isInAir = true;
        }

        var moveVector = movingVectorVertical + movingVectorHorizontal;
        rigidBody.velocity = moveVector;

        rigidBody.rotation = Quaternion.Euler(rigidBody.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Input.GetAxis("Mouse X"), 0f));
        mainCamera.transform.rotation =
            Quaternion.Euler(mainCamera.transform.rotation.eulerAngles + new Vector3(-rotationSpeed * Input.GetAxis("Mouse Y"), 0f, 0f));
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
            isInAir = false;
    }
}
