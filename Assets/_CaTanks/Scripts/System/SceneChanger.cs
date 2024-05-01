using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private int sceneIndex;
    public void ChangeScene(int sceneIndex = -1)
    {
        if (sceneIndex == -1) 
        { 
            sceneIndex = this.sceneIndex; 
        }

        SceneManager.LoadScene(sceneIndex);
    }
}
