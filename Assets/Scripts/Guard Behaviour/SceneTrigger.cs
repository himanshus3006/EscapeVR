using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {

       UnityEngine.SceneManagement.SceneManager.LoadScene(2);

    }
}