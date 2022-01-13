using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class IsGrabbed : MonoBehaviour
{
    // can be set in the Inspector for this script
    //public string sceneName;
    // alternatively, you can do something like
    private const string sceneName = "Scene2";


    public XRGrabInteractable grabbableThingy;

    // Start is called before the first frame update
    void Start()
    {
        grabbableThingy = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("grabbableThingy.isSelected= " + grabbableThingy.isSelected);
        if (grabbableThingy.isSelected) //if pin has been successfully grabbed,
        {
            Debug.Log("Item Selected!!!");//Debug
            SceneManager.LoadScene(sceneName);  //Switch scenes!
        }
    }
}
