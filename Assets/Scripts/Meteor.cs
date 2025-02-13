using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float EndPosition;

    public float speed;

    void Update()
    {
        Vector2 distance = new Vector2(-1, 0);
        transform.Translate(distance * (speed + GameSpeedManager.instance.speed) * Time.deltaTime);

        if (transform.position.x <= EndPosition)
        {
            Destroy(gameObject);
        }
    }
}
