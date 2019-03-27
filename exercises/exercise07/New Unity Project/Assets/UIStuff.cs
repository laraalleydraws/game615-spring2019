using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIStuff : MonoBehaviour
{
    public Button level1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            loadIntro();
        }

        level1.onClick.AddListener(loadLevel1);
        
    }

    public void loadIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene("exercise07");
    }

    public void loadLevel2()
    {

        SceneManager.LoadScene("level2");
    }

}
