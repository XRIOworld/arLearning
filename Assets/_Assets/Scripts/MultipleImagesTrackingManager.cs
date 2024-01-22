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

        // Do similar logging for eventArgs.updated and eventArgs.removed
        // ...
    }

    private void UpdateTrackedImage(ARTrackedImage trackedImage)
    {
        string imageName = trackedImage.referenceImage.name;

        if (string.IsNullOrEmpty(imageName) || !_arObjects.ContainsKey(imageName))
        {
            Debug.LogError("Invalid or missing image name: " + imageName);
            return;
        }

        GameObject arObject = _arObjects[imageName];

        if (trackedImage.trackingState != TrackingState.None && trackedImage.trackingState != TrackingState.Limited)
        {
            arObject.SetActive(true);
            arObject.transform.position = trackedImage.transform.position;
        }
        else
        {
            arObject.SetActive(false);
        }
    }
}
