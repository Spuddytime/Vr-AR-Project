using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    public GameObject lockpick; // Reference to the lockpick
    public float unlockDistance = 2f; // Distance required to unlock
    private bool isUnlocked = false;

    void Update()
    {
        if (lockpick != null && !isUnlocked)
        {
            float distance = Vector3.Distance(lockpick.transform.position, transform.position);
            
            // Check if the lockpick is close enough
            if (distance <= unlockDistance)
            {
                Debug.Log("Door Unlocked!");
                UnlockDoor();
            }
        }
    }

    void UnlockDoor()
    {
        isUnlocked = true;

        // Example: Move the door up to "open" it
        transform.position += new Vector3(0, 3, 0);

        // Optional: Disable the trigger or collider to make the door unresponsive after unlocking
        GetComponent<BoxCollider>().enabled = false;
    }
}
