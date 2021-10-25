using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
   public playerHealth = 100;

   public playerMaxHealth;

   enemyDamage = 25;

    private GameObject redHeart;
    private GameObject yellowHeart;
    private GameObject blueHeart;
    private gameObject slimeEnemy;

    void Start()
    {
        playerHealth = playerMaxHealth;
        redHeart = GameObject.Find("RedHeart");
        yellowHeart = GameObject.Find("YellowHeart");
        blueHeart = GameObject.Find("BlueHeart");
    }

    void Update()
    {
        HealthSystem();
    }

    public void HealthSystem()
    {
        if()
        {
            playerHealth -= enemyDamage;
        }

        if(playerHealth >= 76)
        {
            blueHeart.enabled = true;
            yellowHeart.enabled = false;
            redHeart.enabled = false;
        }
        else if(playerHealth >= 26)
        {
            blueHeart.enabled = false;
            yellowHeart.enabled = true;
            redHeart.enabled = false;
        }
        else if(playerHealth >=  1)
        {
            blueHeart.enabled = false;
            yellowHeart.enabled = false;
            redHeart.enabled = true;
        }
        else if(playerHealth <= 0)
        {
            blueHeart.enabled = false;
            yellowHeart.enabled = false;
            redHeart.enabled = false;
            Application.LoadLevel(0);
        }

    }
}