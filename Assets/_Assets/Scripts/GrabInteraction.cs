using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabInteraction : MonoBehaviour
{
    [SerializeField] private GameObject handPointer;
    //[SerializeField] private GameObject objectToSpawn; // Object to spawn on click gesture
    [SerializeField] private string animationClipName; // Name of the animation clip to play

    private float skeletonConfidence = 0.00001f;
    private GameObject grabbedObject;
   // private Vector3 spawnPosition; // Recorded position for spawning objects

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

/*          if (grabbedObject == null && ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_trigger == ManoGestureTrigger.CLICK)
            {
                // Spawn object on click gesture
                SpawnObject();
            }
            if (grabbedObject == null && ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_trigger == ManoGestureTrigger.PICK)
            {
                // PlayAnim on TAP_POINTING gesture
                PlayAnim();
            }
*/
            if (grabbedObject == null && ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_trigger == ManoGestureTrigger.GRAB_GESTURE)
            {
                // Attempt to grab object
                TryGrabObject();
            }
        }
        else
        {
            handPointer.transform.DetachChildren();
            handPointer.SetActive(false);
        }
    }

/*    void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            // Record the hand pointer's position at the moment of spawning
            spawnPosition = handPointer.transform.position;

            // Spawn the assigned object at the recorded position
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            Debug.Log("Object spawned: " + objectToSpawn.name);
        }
        else
        {
            Debug.LogWarning("Object to spawn is not assigned!");
        }
    }

    void PlayAnim()
    {
        if (grabbedObject != null)
        {
            // Check if the spawned object has an Animator component
            Animator animator = grabbedObject.GetComponent<Animator>();

            // If the spawned object has an Animator component and the animation clip name is not empty, play its animation
            if (animator != null && !string.IsNullOrEmpty(animationClipName))
            {
                animator.Play(animationClipName);
            }
            else
            {
                Debug.LogWarning("No Animator component found on the spawned object or animation clip name is empty.");
            }
        }
        else
        {
            Debug.LogWarning("No object is grabbed to play animation.");
        }
    }
*/
    void TryGrabObject()
    {
        if (grabbedObject == null)
        {
            Collider[] colliders = Physics.OverlapSphere(handPointer.transform.position, 0.1f); // Adjust radius as needed

            foreach (Collider collider in colliders)
            {
                if (collider.CompareTag("Grabbable"))
                {
                    GrabObject(collider.gameObject);
                    break;
                }
            }
        }
    }

    void GrabObject(GameObject obj)
    {
        grabbedObject = obj;
        // Implement logic to grab the object
        Debug.Log("Grabbed: " + obj.name);
    }

    void ReleaseObject()
    {
        if (grabbedObject != null)
        {
            // Implement logic to release the object
            grabbedObject = null;
        }
    }
}
