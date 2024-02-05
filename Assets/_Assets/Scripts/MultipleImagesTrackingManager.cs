using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MultipleImagesTrackingManager : MonoBehaviour
{
    [Serializable]
    public struct ImageToPrefab
    {
        public string imageName;
        public GameObject mainPrefab;
        public GameObject spotlightPrefab;
    }

    [SerializeField] private ImageToPrefab[] imageToPrefabMappings;

    private ARTrackedImageManager _arTrackedImageManager;
    private Dictionary<string, GameObject> _arObjects;

    private void Awake()
    {
        _arTrackedImageManager = GetComponent<ARTrackedImageManager>();
        _arObjects = new Dictionary<string, GameObject>();

        // Initialize the dictionary
        foreach (var mapping in imageToPrefabMappings)
        {
            GameObject newARObject = Instantiate(mapping.mainPrefab, Vector3.zero, Quaternion.identity);
            newARObject.name = mapping.mainPrefab.name;
            newARObject.SetActive(false);
            _arObjects.Add(mapping.imageName, newARObject);

            // Spawn spotlight prefab
            GameObject spotlight = Instantiate(mapping.spotlightPrefab, Vector3.zero, Quaternion.identity);
            spotlight.SetActive(false);
            _arObjects.Add(mapping.imageName + "_Spotlight", spotlight);
        }
    }

    private void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnTrackedImageChanged;
    }

    private void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnTrackedImageChanged;
    }

    private void OnTrackedImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            UpdateTrackedImage(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateTrackedImage(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            _arObjects[trackedImage.referenceImage.name].SetActive(false);
            _arObjects[trackedImage.referenceImage.name + "_Spotlight"].SetActive(false);
        }
    }

    private void UpdateTrackedImage(ARTrackedImage trackedImage)
    {
        string imageName = trackedImage.referenceImage.name;
        GameObject arObject = _arObjects[imageName];
        GameObject spotlight = _arObjects[imageName + "_Spotlight"];

        if (trackedImage.trackingState != TrackingState.None && trackedImage.trackingState != TrackingState.Limited)
        {
            arObject.SetActive(true);
            arObject.transform.position = trackedImage.transform.position;
            arObject.transform.rotation = trackedImage.transform.rotation;

            spotlight.SetActive(true);
            spotlight.transform.position = trackedImage.transform.position;
            // Optionally, update spotlight rotation and scale if needed
            spotlight.transform.rotation = trackedImage.transform.rotation;
            spotlight.transform.localScale = trackedImage.transform.localScale;
        }
        else
        {
            arObject.SetActive(false);
            spotlight.SetActive(false);
        }
    }
}
