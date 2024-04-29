using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MousePositionInTerrain : MonoBehaviour
{
    [SerializeField] private LayerMask mask = new LayerMask();
    [SerializeField] private UnityEvent<Vector3> onMousePosition = new UnityEvent<Vector3>();


    void Update()
    {
       
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;

        if (Physics.Raycast(ray, out hitData, Mathf.Infinity, mask))
        {
            onMousePosition?.Invoke(hitData.point);
        }
    }
}
