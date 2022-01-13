using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class IsGrabbedScene2 : MonoBehaviour
{
    // can be set in the Inspector for this script
    //public string sceneName;
    // alternatively, you can do something like
    private const string sceneName = "Scene1";

    // time after this script initializes, in seconds,
    // that the scene transition will happen
    private const float TIME_LIMIT = 3F; //seconds

    // timer variable
    private float timer = 0F;
    // alternatively, you can set this in an Awake() function,
    // which is automatically called when the script initializes

    // automatically called many times every second

    public XRGrabInteractable grabbableThingy;

    // Start is called before the first frame update
    void Start()
    {
        grabbableThingy = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        // deltaTime is the time (measured in seconds) since the previous Update step
        // it's typically very small, e.g. 1/60th of a second ~= 0.0167F
        this.timer += Time.deltaTime;

        // Check to see if the pin has been dropped only if we are less than 3 seconds into Scene2
        if (this.timer <= TIME_LIMIT) //if less than 3 seconds have elapsed...
        {
            if (!grabbableThingy.isSelected) //if pin has been Dropped, go back to Scene1
            {
                //Debug.Log("Item Selected!!!");//Debug
                SceneManager.LoadScene(sceneName);  //Switch scenes!
            }
        }
    }
}
