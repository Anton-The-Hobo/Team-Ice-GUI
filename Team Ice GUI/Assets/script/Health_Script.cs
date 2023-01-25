using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health_Script : MonoBehaviour
{
    public int HealthRightNow = 50;
    public int HealthTotheMax = 100;
    public int Damage = 10;
    public int Healing = 10;

    public HealthBar_Script healthBar;

    public SpriteRenderer spriteRender;
    public Sprite healthyMonster;
    public Sprite dyingMonster;

    // Start is called before the first frame update
    void Start()
    {
        HealthRightNow = HealthTotheMax;
        healthBar.SetMaxHealth(HealthTotheMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthRightNow <= 0 )
        {
            Destroy(healthBar.gameObject);
            Destroy(gameObject);
        }

        if (HealthRightNow <= 50)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = dyingMonster;
        }

        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = healthyMonster;
        }
    }
    public void Kill()
    {
        HealthRightNow -= Damage;
        healthBar.SetHealth(HealthRightNow);
    }

    public void Heal()
    {
        if (HealthRightNow < HealthTotheMax)
        {
            HealthRightNow += Healing;
            healthBar.SetHealth(HealthRightNow);
        }
        else
        {
            HealthRightNow = HealthTotheMax;
        }
    }

    
        
    
}
