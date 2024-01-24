using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MultipleImagesTrackingManager : MonoBehaviour
{
    [System.Serializable]
    public class ImageToPrefab
    {
        public string imageName;
        public GameObject prefab;
    }

    [SerializeField] private ImageToPrefab[] imageToPrefabMappings;

    private ARTrackedImageManager _arTrackedImageManager;
    private Dictionary<string, GameObject> _arObjects;

    private void Awake()
    {
        _arTrackedImageManager = GetComponent<ARTrackedImageManager>();
        _arObjects = new Dictionary<string, GameObject>();
    }

    private void Start()
    {
        _arTrackedImageManager.trackedImagesChanged += OnTrackedImageChanged;

        foreach (var mapping in imageToPrefabMappings)
        {
            GameObject newARObject = Instantiate(mapping.prefab, Vector3.zero, Quaternion.identity);
            newARObject.name = mapping.prefab.name;
            newARObject.SetActive(false);
            _arObjects.Add(mapping.imageName, newARObject);
        }
    }

    private void OnDestroy()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnTrackedImageChanged;
    }

    private void OnTrackedImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            if (trackedImage.referenceImage.name == null)
            {
                Debug.LogError("Added image has null name.");
            }
            UpdateTrackedImage(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateTrackedImage(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            _arObjects[trackedImage.referenceImage.name].SetActive(false);
        }


    }

    private void UpdateTrackedImage(ARTrackedImage trackedImage)
    {
        string imageName = trackedImage.referenceImage.name;
        GameObject arObject = _arObjects[imageName];

        if (trackedImage.trackingState != TrackingState.None && trackedImage.trackingState != TrackingState.Limited)
        {
            arObject.SetActive(true);
            arObject.transform.position = trackedImage.transform.position;
            arObject.transform.rotation = trackedImage.transform.rotation;
            //arObject.transform.localScale = trackedImage.transform.localScale;
        }
        else
        {
            arObject.SetActive(false);
        }
    }
}
