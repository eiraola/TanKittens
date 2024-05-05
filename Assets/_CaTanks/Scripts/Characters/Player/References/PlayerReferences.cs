using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReferences : MonoBehaviour
{
    [Header("Player references")]
    [SerializeField] private Transform _playerBodyRef;
    [SerializeField] private Transform _playerHeadRef;
    [SerializeField] private List<Transform> _playerHeadChildren;
    [SerializeField] private Transform _firepoint;

    public Transform PlayerBodyRef { get => _playerBodyRef;}
    public Transform PlayerHeadRef { get => _playerHeadRef;}
    public List<Transform> PlayerHeadChildren { get => _playerHeadChildren;}
    public Transform Firepoint { get => _firepoint;}
    public UICommunications xd;
}
