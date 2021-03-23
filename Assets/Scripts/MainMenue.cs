using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonQuit()
    {
        Application.Quit();//quit game
        //#if is preprossor code, if unity editor is running, this statement is true
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//stop editor
#endif
    }
    public void ButtonStart()
    {
        SceneManager.LoadScene("Main");
    }
}