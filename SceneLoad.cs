using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    //scene name
    public string _sceneName;

    //custom wait for scene to load time
    public float _waitTime;

    //function
    IEnumerator LoadingScene()
    {
        //waiting
        yield return new WaitForSeconds(_waitTime);

        //loading
        SceneManager.LoadScene(_sceneName);


       
    }

    //button
    public void LoadBtn()
    {
        //call load function
        StartCoroutine(LoadingScene());
    }

    //save script
    //Subscribe to MyChannel 
    // get scripts on github
    //Thank you!

    //Process...........//

    //in unity 
    //create an empty gameObject
    //attach this script
    //create a button 
    //call function from gameObject

}
