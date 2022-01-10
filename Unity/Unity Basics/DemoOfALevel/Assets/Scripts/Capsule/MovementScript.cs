using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 2;
    private int xAxisBackwardMovement = 0;
    private int zAxisForwardMovement = 0;
    private int currentX = 0;
    private int currentZ = 0;
    private const int availableRoomsInACorridor = 2;
    private const int initialPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (zAxisForwardMovement.Equals(0) && xAxisBackwardMovement < availableRoomsInACorridor) // Bottom right, initial
        {
            xAxisBackwardMovement++;
            currentX = (int)((-1 * (xAxisBackwardMovement * 10)) /** speed * Time.deltaTime*/);
        }
        else if (zAxisForwardMovement < availableRoomsInACorridor && xAxisBackwardMovement.Equals(availableRoomsInACorridor)) // Bottom left
        {
            zAxisForwardMovement++;
            currentZ = (int)((zAxisForwardMovement * 10) /** speed * Time.deltaTime*/);
        }
        else if (zAxisForwardMovement.Equals(availableRoomsInACorridor) && xAxisBackwardMovement > initialPosition) // Top left, diagonal
        {
            xAxisBackwardMovement--;
            currentX = (int)((-1 * (xAxisBackwardMovement * 10)) /** speed * Time.deltaTime*/);
        }
        else if (zAxisForwardMovement > initialPosition && xAxisBackwardMovement.Equals(0)) // Top right
        {
            zAxisForwardMovement--;
            currentZ = (int)((zAxisForwardMovement * 10) /** speed * Time.deltaTime*/);
        }

        transform.position = new Vector3(currentX, 0, currentZ);
    }
}
