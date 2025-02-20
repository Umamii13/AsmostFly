using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Transform[] position;
    public int Positionnow;
    public Animator anim;
    public AudioSource EffectSound;
    public AudioClip CrashEffect;
    void Start()
    {
        EffectSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.GameOver)
        {
            return;
        }
        else
        {
            Flip();
        }
    }

    public void Flip()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {

            if (Positionnow == 2)
            {
                if (anim != null)
                {
                    anim.SetBool("Flip",true);
                }
                int calculatePos = 1;
                transform.position = position[calculatePos].position;
                Positionnow = calculatePos;
                
            }
            else if (Positionnow == 1)
            {
                if (anim != null)
                {
                    anim.SetBool("Flip", true);
                }
                int calculatePos = 0;
                transform.position = position[calculatePos].position;
                Positionnow = calculatePos;
                
            }
            else if (Positionnow == 0)
            {
                int calculatePos = 0;
                transform.position = position[calculatePos].position;
                Positionnow = calculatePos;
            }
            
            
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (Positionnow == 2)
            {
                int calculatePos = 2;
                transform.position = position[calculatePos].position;
                Positionnow = calculatePos;
            }
            else if (Positionnow == 1)
            {
                if (anim != null)
                {
                    anim.SetBool("Flip", true);
                }
                int calculatePos = 2;
                transform.position = position[calculatePos].position;
                Positionnow = calculatePos;
                
            }
            else if (Positionnow == 0)
            {
                if (anim != null)
                {
                    anim.SetBool("Flip", true);
                }
                int calculatePos = 1;
                transform.position = position[calculatePos].position;
                Positionnow = calculatePos;
                
            }
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Meteor"))
        {
            EffectSound.PlayOneShot(CrashEffect, 1f);
            GameManager.Instance.playerlife -= 1;
            Destroy(collision.gameObject);
            UIManager.Instance.UpdateLife();
            //playSound in soundmanager

        }
    }
}


