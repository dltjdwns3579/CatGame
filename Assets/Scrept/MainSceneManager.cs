using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void gamescene()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
