using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewCommunicationScript", menuName = "ScriptableObjects/Communications/UI", order = 1)]
[System.Serializable]
public class UICommunications : ScriptableObject
{
   public UnityEvent<int> onLifeChange = new UnityEvent<int>();
}