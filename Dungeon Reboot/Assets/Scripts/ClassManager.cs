using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassManager : MonoBehaviour
{
    //Variables
    public int healthMax;
    public int manaMax;
    public int expMax;

    //Stats
    //1 Assignable Point per Level
    public int level = 1;
    //Dodge Chance + 5%/1 point(?) (From 5% base)
    public int dex = 1;
    //Attack Strength + 1/Point (Adds on to weapon attack)
    public int str = 1;
    //Health + 5/1 point(?) (Adds on to class base)
    public int vit = 1;
    //Mana + 5/1 point(?) (Adds on to clase base)
    public int intel = 1;
    //Makes negotiations more successfull + 5%/Point (From 5% base)
    public int cha = 1;
    //Increases Drop Chance, as well as give a 5% boost to Dodge and Negotiations per point (From 5% base)
    public int luk = 1;   

    //Bars
    int health;
    int mana;
    int exp; 

    public Text healthBar;
    public Text manaBar;
    public Text expBar;
    public Slider HealthBarVal;
    public Slider ManaBarVal;
    public Slider ExpBarVal;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.cconfirm2 == 2)
        {
            Stats();
        }

        SetBarValue();
    }

    
    void Stats()
    {
       
        if(GameManager.classnum == 1)
        {
            healthMax = 75;
            health = 75;
            manaMax = 30;
            mana = 30;
            expMax = 50;
            exp = 0;
            dex = dex + 2;
            luk = luk + 2;
            GameManager.cconfirm2 = 3;
        }
    
        if(GameManager.classnum == 2)
        {
            healthMax = 50;
            health = 50;
            manaMax = 75;
            mana = 75;
            expMax = 50;
            exp = 0;
            intel = intel + 2;
            luk = luk + 2;
            GameManager.cconfirm2 = 3;
        }

        if(GameManager.classnum == 3)
        {
            healthMax = 125;
            health = 125;
            manaMax = 30;
            mana = 30;
            expMax = 50;
            exp = 0;
            vit = vit + 2;
            cha = cha + 2;
            GameManager.cconfirm2 = 3;
        }

        if(GameManager.classnum == 4)
        {
            healthMax = 75;
            health = 75;
            manaMax = 40;
            mana = 40;
            expMax = 50;
            exp = 0;
            dex = dex + 2;
            cha = cha + 2;
            GameManager.cconfirm2 = 3;
        }

        if(GameManager.classnum == 5)
        {
            healthMax = 100;
            health = 100;
            manaMax = 30;
            mana = 30;
            expMax = 50;
            exp = 0;
            vit = vit + 2;
            str = str + 2;
            GameManager.cconfirm2 = 3;
        }

        if(GameManager.classnum == 6)
        {
            healthMax = 100;
            health = 100;
            manaMax = 50;
            mana = 50;
            expMax = 50;
            exp = 0;
            str = str + 2;
            cha = cha + 2;
            GameManager.cconfirm2 = 3;
        }
    }

    public void healthTest()
    {
        health = health - 5;
    }
    

    public void SetBarValue()
    {
        HealthBarVal.maxValue = healthMax;
        HealthBarVal.value = health;
        ManaBarVal.maxValue = manaMax;
        ManaBarVal.value = mana;
        ExpBarVal.maxValue = expMax;
        ExpBarVal.value = exp;
        healthBar.text = health + "/" + healthMax;
        manaBar.text = mana + "/" + manaMax;
        expBar.text = exp + "/" + expMax;
    }
}



