using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    Vector3 zAxisOffset = new Vector3(0, 0, -1);

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        //float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        //transform.position = new Vector2 (player.transform.position.x, player.transform.position.y);
        transform.position = player.transform.position + zAxisOffset;

    }
}
