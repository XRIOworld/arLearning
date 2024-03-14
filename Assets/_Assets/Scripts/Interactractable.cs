using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactractable : MonoBehaviour
{
    public GameObject handPointer;
    public GameObject objectToSpawn;
    private float skeletonConfidence = 0.00001f;

    private GameObject grabbedObject;

    // Update is called once per frame
    void Update()
    {
        bool hasConfidence = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info.skeleton.confidence > skeletonConfidence;
        if (hasConfidence)
        {
            var palmCenter = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info.palm_center;
            var depthEstimation = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info.depth_estimation;

            Vector3 positionPointer = ManoUtils.Instance.CalculateNewPositionDepth(palmCenter, depthEstimation);

            handPointer.transform.position = positionPointer;
            handPointer.SetActive(true);

        //All the information of the hand
        HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;

            if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.CLICK) // Assuming Click gesture triggers object spawn
            {
                SpawnObject();
            }
            else if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.SWIPE_LEFT) // Assuming SWIPE LEFT gesture activates object animation
            {
                ActivateObjectAnimation();
            }
        }
        else
        {
            handPointer.transform.DetachChildren();
            handPointer.SetActive(false);
        }
    }

    void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            // Spawn the assigned object
            GameObject spawnedObject = Instantiate(objectToSpawn, handPointer.transform.position, Quaternion.identity);
            Debug.Log("Object spawned: " + objectToSpawn.name);

            // Optionally, deactivate the spawned object if it's not meant to be visible immediately
            spawnedObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Object to spawn is not assigned!");
        }
    }

    void ActivateObjectAnimation()
    {
        // Implement logic to activate object animation
        Debug.Log("Object animation activated");
    }
}
