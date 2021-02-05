using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using TMPro.Examples;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            this.transform.position = new Vector3((float) -9.3, -2.68f, 0f);
            
        }
    }
}
