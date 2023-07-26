using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraZoom : MonoBehaviour
{
    float zoom;
    float zoomMultiplier = 4f;
    float minZoom = 5f;
    float maxZoom = 20f;
    float velocity = 0f;
    float smoothTime = 0.25f;

    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    CinemachineComponentBase componentBase;


    

    private void Start()
    {
        if (componentBase == null)
            componentBase = virtualCamera.GetCinemachineComponent(CinemachineCore.Stage.Body);

        zoom = virtualCamera.m_Lens.OrthographicSize;
    }

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        virtualCamera.m_Lens.OrthographicSize = Mathf.SmoothDamp(virtualCamera.m_Lens.OrthographicSize, zoom, ref velocity, smoothTime);
    }
}
