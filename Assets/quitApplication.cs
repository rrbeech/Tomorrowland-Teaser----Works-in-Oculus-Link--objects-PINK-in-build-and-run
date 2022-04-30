using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class quitApplication : MonoBehaviour
{

    private const float TIME_LIMIT = 21F; //seconds
    // timer variable
    private float timer = 0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // deltaTime is the time (measured in seconds) since the previous Update step
        // it's typically very small, e.g. 1/60th of a second ~= 0.0167F
        this.timer += Time.deltaTime;

        // check if it's time to end
        if (this.timer >= TIME_LIMIT)
        {
            QuitMyGame();
        }
    }

    public void QuitMyGame()
    {
#if UNITY_EDITOR
        if (EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#endif
        Application.Quit(); // This row is ignored in the editor
    }
}
