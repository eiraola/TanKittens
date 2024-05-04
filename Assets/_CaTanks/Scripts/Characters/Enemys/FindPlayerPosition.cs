using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FindPlayerPosition : MonoBehaviour
{
    [SerializeField] public UnityEvent<Vector3> _onPlayerPosFound = new UnityEvent<Vector3>();

    public void FindPlayerPos()
    {
        GameObject go = GameObject.FindGameObjectWithTag(Constants.TAG_PLAYER);
        _onPlayerPosFound?.Invoke(go.transform.position);
    }

    private void Update()
    {
        FindPlayerPos();
    }
}
