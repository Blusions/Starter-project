using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playagain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
