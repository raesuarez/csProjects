using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class collectible : MonoBehaviour
{
    public UnityEvent collectPart;
    public AudioSource collect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.tag == "shipPart") ;
        {
            collectPart.Invoke();
            collect.Play();

        }

        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }


    }
}
