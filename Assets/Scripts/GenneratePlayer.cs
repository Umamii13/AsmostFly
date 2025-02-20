using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenneratePlayer : MonoBehaviour
{
    public PlayerControler me;
    public GameObject[] player;

    void Start()
    {
        Instantiate(player[PlayerPrefs.GetInt("ChSelect")], gameObject.transform);
        me = gameObject.GetComponent<PlayerControler>();
        me.anim = gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
