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
    private int levelMax = 0;
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
    public Text healthBarVal;
    public Text manaBarVal;
    public Text expBarVal;
    public Slider HealthBar;
    public Slider ManaBar;
    public Slider ExpBar;
    public Button healthTestButton;
    public Text strVal;
    public Text vitVal;
    public Text intelVal;
    public Text dexVal;
    public Text chaVal;
    public Text lukVal;
 


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
        levelUp();
        StatManager();
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
        if (health == 0)
        {
            healthTestButton.interactable = false;

        }

    }

    public void expTest()
    {
        if(level != 20)
        {
        exp += 100;
        }
    }
    

    public void SetBarValue()
    {
        HealthBar.maxValue = healthMax;
        HealthBar.value = health;
        ManaBar.maxValue = manaMax;
        ManaBar.value = mana;
        ExpBar.maxValue = expMax;
        ExpBar.value = exp;
        healthBarVal.text = health + "/" + healthMax;
        manaBarVal.text = mana + "/" + manaMax;
        expBarVal.text = exp + "/" + expMax;
    }

    public void levelUp()
    {
        if (exp >= expMax && level != 20)
        {
            exp = exp - expMax;
            expMax += 25;
            level += 1;


        }

        if (exp >= expMax && level == 20 && levelMax == 0)
        {
            exp = expMax;
            expBarVal.text = "Max Level";
            levelMax = 1;
        }
    }

    public  void StatManager()
    {
        strVal.text = "" + str;
        vitVal.text = "" + vit;
        intelVal.text = "" + intel;
        dexVal.text = "" + dex;
        chaVal.text = "" + cha;
        lukVal.text = "" + luk;
    }
}



