using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]

public class SpawnObj : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn; // The object to spawn
    private string handTag = "Player"; // Tag for the hand object
    private Transform handPointer; // Reference to the hand pointer object

    void Start()
    {
        // Assuming hand pointer is a child object, find it by name
        handPointer = transform.Find("HandPointer");
        if (handPointer == null)
        {
            Debug.LogError("HandPointer not found. Make sure it is a child object.");
        }
    }

    void Update()
    {
        // Check if a grab gesture is detected
        if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_trigger == ManoGestureTrigger.CLICK)
        {
            SpawnObject();
        }
        // Check if a release gesture is detected and the object has a parent
        else if (ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_trigger == ManoGestureTrigger.RELEASE_GESTURE &&
                 transform.parent != null)
        {
            // Release the object
            transform.parent = null;
        }
    }

    // Spawn the object
    void SpawnObject()
    {
        if (objectToSpawn != null && handPointer != null)
        {
            // Record the hand pointer's position at the moment of spawning
            Vector3 spawnPosition = handPointer.position;

            // Spawn the assigned object at the recorded position
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            Debug.Log("Object spawned: " + objectToSpawn.name);
        }
        else
        {
            Debug.LogWarning("Object to spawn or hand pointer is not assigned!");
        }
    }
}
