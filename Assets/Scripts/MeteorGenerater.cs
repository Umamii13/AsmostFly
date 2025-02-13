using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerater : MonoBehaviour
{
    public GameObject meteor;

    public Transform template;

    float tic;

    void Start()
    {
        Instantiate(meteor,gameObject.transform.position,Quaternion.identity);
        template = transform.parent;
        
    }

    private void Update()
    {
        tic += Time.deltaTime;
        if ( tic > 0.5 )
        {
            if (template != null)
            {
                Destroy(template.gameObject);

            }
        }

    }

}
