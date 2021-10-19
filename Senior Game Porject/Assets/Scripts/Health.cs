using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;

    public Health()
    {
        numOfHearts = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //how many hearts the player will have
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (numOfHearts <= 0)
        {
            Application.LoadLevel(0);
        }

        //for testing if the hearts will go down
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            numOfHearts -= 1;
        }
    }

    private void OnCollision(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            numOfHearts -= 1;
        }
    }
}