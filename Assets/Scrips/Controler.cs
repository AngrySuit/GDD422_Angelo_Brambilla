using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controler : MonoBehaviour
{

    [SerializeField] List<string> scenes;
    string nextScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (0 == gameObject.transform.childCount)
        {
            

            var target = SceneManager.GetActiveScene().name;

            foreach (string Scene in scenes)
            {
                if (Scene == target)
                {
                    nextScene = Scene;
                }
            }

            SceneManager.LoadScene(nextScene);
        }
    }
}
