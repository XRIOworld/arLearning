using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]

public class ObjectManipulator : MonoBehaviour
{
    //this below is for if I spawn an object
    [SerializeField] private GameObject handPointer;
    public GameObject objectToSpawn;
    private Vector3 spawnPosition; // Recorded position for spawning objects

    [SerializeField] private Material[] materials = new Material[2];
    private Renderer objectRenderer;
    private string handTag = "Player";
    private bool isGrabbing;
    private float skeletonConfidence = 0.00001f;



    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {

        ManomotionManager.Instance.ShouldCalculateGestures(true);

        var currentGesture = ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info.mano_gesture_trigger;

        if (currentGesture == ManoGestureTrigger.GRAB_GESTURE)
        {
            isGrabbing = true;
        }

        else if (currentGesture == ManoGestureTrigger.RELEASE_GESTURE)
        {
            isGrabbing = false;
            transform.parent = null;
        }

        bool hasConfidence = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info.skeleton.confidence > skeletonConfidence;

        if (!hasConfidence)
        {
            objectRenderer.sharedMaterial = materials[0];
        }
    }
    
    void SpawnObject()
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
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(handTag))
        {
            objectRenderer.sharedMaterial = materials[1];
            Handheld.Vibrate();

        }
        else if (isGrabbing)
        {
            transform.parent = other.gameObject.transform;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(handTag) && isGrabbing)
        {
            transform.parent = other.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
        objectRenderer.sharedMaterial = materials[0];
    }

}