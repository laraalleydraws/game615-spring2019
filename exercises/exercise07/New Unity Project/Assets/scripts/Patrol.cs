using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Patrol : MonoBehaviour
{
    public Transform[] patrolPoints;

    private int currentPoint;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    { if (transform.position == patrolPoints[currentPoint].position)
        {
           //  SceneManager.LoadScene("");
        }

    }
}
