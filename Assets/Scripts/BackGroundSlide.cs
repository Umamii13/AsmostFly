using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackGroundSlide : MonoBehaviour
{
    public float EndPosition;
    public float StartPosition;

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 distance = new Vector2(-1,0);
        transform.Translate(distance * (speed + GameSpeedManager.instance.speed/10)  * Time.deltaTime);

        if(transform.position.x <= EndPosition)
        {
            transform.position = new Vector2(StartPosition,0);
        }
    }
}
