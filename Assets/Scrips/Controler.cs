using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controler : MonoBehaviour
{

    [SerializeField] List<string> scenes;
    string nextScene;
    int index;

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
                    nextScene = scenes[index + 1];
                }
                else
                {
                    index += 1;
                }
            }

            SceneManager.LoadScene(nextScene);
        }
    }
}
