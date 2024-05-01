using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReferencesGetter : MonoBehaviour
{
    [SerializeField] private PlayerReferences _playerReferences;

    [Header("PlayerGO")]
    [SerializeField] private Transform _playerTransform;

    [Header("ScriptReferences")]
    [SerializeField] private RotateToMovement _rotateToMovement;
    [SerializeField] private RotateToPosition _rotateToPosition;
    [SerializeField] private ProjectileLauncher _projectileLauncher;

    private void Start()
    {
        SetPlayerReferences();
    }
    
    private void SetPlayerGO() { 
        _playerTransform.parent = transform; 
        _playerTransform.localRotation = Quaternion.identity;
        _playerTransform.localPosition = Vector3.zero;
    }
    public void SetPlayerReferences()
    {
        SetPlayerGO();
        SetRotateToMovementVars();
        SetRotateToPositionVars();
        SetProjectileLauncherVars();
    }

    public void SetRotateToMovementVars() {
        _rotateToMovement.transformObject = _playerReferences.PlayerBodyRef;
    }

    public void SetRotateToPositionVars()
    {
        foreach (Transform reference in _playerReferences.PlayerHeadChildren)
        {
            reference.parent = _playerReferences.PlayerHeadRef;
        }
        _rotateToPosition.transformObject = _playerReferences.PlayerHeadRef;
    }

    public void SetProjectileLauncherVars()
    {
        _projectileLauncher.firePoint = _playerReferences.Firepoint;
    }
}
