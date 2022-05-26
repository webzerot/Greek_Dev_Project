using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer_Script : MonoBehaviour
{
    public void ChangeSceneOnBtn(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
