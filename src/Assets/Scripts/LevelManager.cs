using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {

    public void LoadLv(string LevelName)
    {
        SceneManager.LoadSceneAsync(LevelName);
    }

    public void QuitRequest()
    {
        Application.Quit();
    }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
