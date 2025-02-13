using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedManager : MonoBehaviour
{
    public static GameSpeedManager instance {  get; private set; }

    public float speed;
    public float MaxSpeed;
    public float SpeedofTime;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(speed < MaxSpeed)
        {
            speed += SpeedofTime * Time.deltaTime;
        }
        else
        {
            speed = MaxSpeed;
        }
    }
}
