using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTemplate : MonoBehaviour
{
    [Header("Template")]
    public GameObject[] template;

    [Header("TimeSetting")]
    public float triggertime;
    public float timetig;
    public bool canSpawn;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.GameOver)
        {
            return;
        }
        else
        {
            triggertime += (1 + GameSpeedManager.instance.speed / 3) * Time.deltaTime;
            if (triggertime >= timetig)
            {
                canSpawn = true;
                Spawn();
                triggertime = 0;
            }
        }
    }

    void Spawn()
    { 
        if (canSpawn)
        {
            int ran = Random.Range(0, template.Length);
            Instantiate(template[ran], gameObject.transform.position, Quaternion.identity);
            canSpawn = false;
        } 
    }
}
