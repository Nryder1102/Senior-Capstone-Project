using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassManager : MonoBehaviour
{
    //Variables
    public static int healthMax;
    public static int healthMaxFlag;
    public static int manaMax;
    public static int manaMaxFlag;
    public int expMax = 50;
    public Text statClass;

    //Stats
    //1 Assignable Point per Level
    public int level = 1;
    private int levelMax = 0;
    //Dodge Chance + 5%/1 point(?) (From 5% base)
    public static int dex = 0;
    //Attack Strength/(Maybe Defense too?) + 1/Point (Adds on to weapon attack)
    public static int str = 0;
    //Health + 5/1 point(?) (Adds on to class base)
    public static int vit = 0;
    //Mana + 5/1 point(?) (Adds on to clase base)
    public static int intel = 0;
    //Makes negotiations more successfull + 5%/Point (From 5% base)
    public static int cha = 0;
    //Increases Drop Chance, as well as give a 5% boost to Dodge and Negotiations per point (From 5% base)
    public static int luk = 0;
    public static int attr = 4;
    public static int attrConfirm = 0;
    public static int attrFlag = 4;
    public Text attributePoints;
    public Button strplus;
    public Button strmin;
    public Button vitplus;
    public Button vitmin;
    public Button dexplus;
    public Button dexmin;
    public Button intplus;
    public Button intmin;
    public Button chaplus;
    public Button chamin;
    public Button lukplus;
    public Button lukmin;
    public static int strFlag;
    public static int vitFlag;
    public static int dexFlag;
    public static int intFlag;
    public static int chaFlag;
    public static int lukFlag;
    public Text levelNum;
    public Text levelNumDD;
    public Button checkConfirm;


    //Bars
    int health;
    int mana;
    int exp = 0; 
    public Text healthBarVal;
    public Text manaBarVal;
    public Text expBarVal;
    public Slider HealthBar;
    public Slider ManaBar;
    public Slider ExpBar;
    public Button healthTestButton;
    public Button expTestButton;
    public Text strVal;
    public Text vitVal;
    public Text intelVal;
    public Text dexVal;
    public Text chaVal;
    public Text lukVal;

    //The modifiers that stats affect
    public int atk = 1;
    public int def = 1;
    public Text attack;
    public Text defense;
    public Text statHealth;
    public Text statMana;
 


    // Start is called before the first frame update
    void Start()
    {
        strplus.interactable = false;
        vitplus.interactable = false;
        dexplus.interactable = false;
        intplus.interactable = false;
        chaplus.interactable = false;
        lukplus.interactable = false;
        strmin.interactable = false;
        vitmin.interactable = false;
        dexmin.interactable = false;
        intmin.interactable = false;
        chamin.interactable = false;
        lukmin.interactable = false;
        checkConfirm.interactable = false;
        if(GameManager.classnum == 0)
        {
            healthTestButton.interactable = false;
        }
        if(GameManager.classnum == 0)
        {
            expTestButton.interactable = false;
        }
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

        if(attrConfirm == 1)
        {
            checkConfirm.interactable = true;
        }
        if(attr == attrFlag || attrConfirm == 0)
        {
            checkConfirm.interactable = false;
        }

        if(attrConfirm == 1 && Input.GetKeyDown(KeyCode.Escape))
        {
            str = strFlag;
            vit = vitFlag;
            dex = dexFlag;
            intel = intFlag;
            cha = chaFlag;
            luk = lukFlag;
            healthMax = healthMaxFlag;
            manaMax = manaMaxFlag;
            attr = attrFlag;
            attrConfirm = 0;
            strmin.interactable = false;
            vitmin.interactable = false;
            dexmin.interactable = false;
            intmin.interactable = false;
            chamin.interactable = false;
            lukmin.interactable = false;
        }

        if(GameManager.classnum != 0 && GameManager.cconfirm2 == 3)
        {
            expTestButton.interactable = true;
            healthTestButton.interactable = true;
        }

        if(attrConfirm == 0)
        {
            strmin.interactable = false;
            vitmin.interactable = false;
            dexmin.interactable = false;
            intmin.interactable = false;
            chamin.interactable = false;
            lukmin.interactable = false;
        }

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
            healthMaxFlag = healthMax;
            manaMaxFlag = manaMax;
//            dex = dex + 2;
//            luk = luk + 2;
            GameManager.cconfirm2 = 3;
            statClass.text = "Rogue";
        }
    
        if(GameManager.classnum == 2)
        {
            healthMax = 50;
            health = 50;
            manaMax = 75;
            mana = 75;
            expMax = 50;
            exp = 0;
            healthMaxFlag = healthMax;
            manaMaxFlag = manaMax;
//            intel = intel + 2;
//            luk = luk + 2;
//            manaMax += intel*5;
            GameManager.cconfirm2 = 3;
            statClass.text = "Mage";
        }

        if(GameManager.classnum == 3)
        {
            healthMax = 125;
            health = 125;
            manaMax = 30;
            mana = 30;
            expMax = 50;
            exp = 0;
            healthMaxFlag = healthMax;
            manaMaxFlag = manaMax;
//            vit = vit + 2;
//            cha = cha + 2;
//            healthMax += vit*5;
            GameManager.cconfirm2 = 3;
            statClass.text = "Paladin";
        }

        if(GameManager.classnum == 4)
        {
            healthMax = 75;
            health = 75;
            manaMax = 40;
            mana = 40;
            expMax = 50;
            exp = 0;
            healthMaxFlag = healthMax;
            manaMaxFlag = manaMax;
//            dex = dex + 2;
//            cha = cha + 2;
            GameManager.cconfirm2 = 3;
            statClass.text = "Ranger";
        }

        if(GameManager.classnum == 5)
        {
            healthMax = 110;
            health = 110;
            manaMax = 30;
            mana = 30;
            expMax = 50;
            exp = 0;
            healthMaxFlag = healthMax;
            manaMaxFlag = manaMax;
//            vit = vit + 2;
//            str = str + 2;
//            healthMax += vit*5;
            GameManager.cconfirm2 = 3;
            statClass.text = "Warrior";
        }

        if(GameManager.classnum == 6)
        {
            healthMax = 100;
            health = 100;
            manaMax = 50;
            mana = 50;
            expMax = 50;
            exp = 0;
            healthMaxFlag = healthMax;
            manaMaxFlag = manaMax;
//            str = str + 2;
//            cha = cha + 2;
            GameManager.cconfirm2 = 3;
            statClass.text = "Beast";
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
        if(level == 20)
        {
            expTestButton.interactable = false;
        }
        if(GameManager.classnum != 0)
        {
            expTestButton.interactable = true;
        }
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
        if(level != 20)
        {
        expBarVal.text = exp + "/" + expMax;
        }
    }

    public void levelUp()
    {
        if (exp >= expMax && level != 20 && GameManager.classnum != 0)
        {
            exp = exp - expMax;
            expMax += 25;
            level += 1;
            attr += 1;
            attrFlag = attr;
            strFlag = str;
            vitFlag = vit;
            dexFlag = dex;
            intFlag = intel;
            chaFlag = cha;
            lukFlag = luk;
            healthMaxFlag = healthMax;
            manaMaxFlag = manaMax;
            health = healthMax;
            mana = manaMax;
            if(level <= 9)
            {
                levelNum.text = "Level: " + level;
            }
            if(level >= 10)
            {
                levelNum.text = "Level: ";
                levelNumDD.text = "" + level;
            }
        }

        if (level == 20 && levelMax == 0)
        {
            exp = expMax;
            expBarVal.text = "Max Level";
            levelMax = 1;
        }
    }

    public void StatManager()
    {
        //Should hopefully be able to switch stat pages using something like this
        //Character Slot 1
        if(GameManager.selectedChar == 0 || GameManager.selectedChar == 1)
        {
        strVal.text = "" + str;
        vitVal.text = "" + vit;
        intelVal.text = "" + intel;
        dexVal.text = "" + dex;
        chaVal.text = "" + cha;
        lukVal.text = "" + luk;
        atk = ItemManager.wpnatk + str;
        def = ItemManager.armdef + str/2;
        attack.text = "" + atk;
        defense.text = "" + def;
        statHealth.text = health + "/" + healthMax;
        statMana.text = mana + "/" + manaMax;   
        if(attr >= 1)
        {
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
            attributePoints.text = "" + attr;
        }
        if(attr == 0)
        {
            attributePoints.text = "" + attr;
        }
        if(str == 20)
        {
            strplus.interactable = false;
        }
        if(vit == 20)
        {
            vitplus.interactable = false;
        }
        if(dex == 20)
        {
            dexplus.interactable = false;
        }
        if(intel == 20)
        {
            intplus.interactable = false;
        }
        if(cha == 20)
        {
            chaplus.interactable = false;
        }
        if(luk == 20)
        {
            lukplus.interactable = false;
        }
        if(GameManager.classnum == 1)
        {
            statClass.text = "Rogue";
        }
        if(GameManager.classnum == 2)
        {
            statClass.text = "Mage";
        }
        if(GameManager.classnum == 3)
        {
            statClass.text = "Paladin";
        }
        if(GameManager.classnum == 4)
        {
            statClass.text = "Ranger";
        }
        if(GameManager.classnum == 5)
        {
            statClass.text = "Warrior";
        }
        if(GameManager.classnum == 6)
        {
            statClass.text = "Beast";
        }
        }



        //Character Slot 2
        if(GameManager.selectedChar == 2)
        {
        statClass.text = "test";
        if(PartyManager.attrp1 >= 1)
        {
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
            attributePoints.text = "" + PartyManager.attrp1;
        }
        if(PartyManager.attrp1 == 0)
        {
            attributePoints.text = "" + PartyManager.attrp1;
        }
        if(str == 20)
        {
            strplus.interactable = false;
        }
        if(vit == 20)
        {
            vitplus.interactable = false;
        }
        if(dex == 20)
        {
            dexplus.interactable = false;
        }
        if(intel == 20)
        {
            intplus.interactable = false;
        }
        if(cha == 20)
        {
            chaplus.interactable = false;
        }
        if(luk == 20)
        {
            lukplus.interactable = false;
        }
        }



    }


    public void StrengthPlus()
    {
        if(str != 20)
        {
        str += 1;
        attr -= 1;
        }
        attrConfirm = 1;
        if(attr == 0)
        {
        strplus.interactable = false;
        vitplus.interactable = false;
        dexplus.interactable = false;
        intplus.interactable = false;
        chaplus.interactable = false;
        lukplus.interactable = false;
        }
        strmin.interactable = true;
    }
    public void StrengthMin()
    {
        if(attr >= 0 && attrConfirm == 1)
        {
            str -= 1;
            attr += 1;
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
        }
        if(attr == attrFlag || str == strFlag)
        {
            strmin.interactable = false;
        }
    }
    public void VitalityPlus()
    {
        if(vit != 20)
        {
        vit += 1;
        attr -= 1;
        healthMax += 5;
        }
        attrConfirm = 1;
        if(attr == 0)
        {
        strplus.interactable = false;
        vitplus.interactable = false;
        dexplus.interactable = false;
        intplus.interactable = false;
        chaplus.interactable = false;
        lukplus.interactable = false;
        }
        vitmin.interactable = true;
    }
    public void VitalityMin()
    {
        if(attr >= 0 && attrConfirm == 1)
        {
            healthMax -= 5;
            vit -= 1;
            attr += 1;
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
        }
        if(attr == attrFlag || vit == vitFlag)
        {
            vitmin.interactable = false;
        }
    }
    public void DexterityPlus()
    {
        if(dex != 20)
            {
            dex += 1;
            attr -= 1;
            }
            attrConfirm = 1;
        if(attr == 0)
        {
            strplus.interactable = false;
            vitplus.interactable = false;
            dexplus.interactable = false;
            intplus.interactable = false;
            chaplus.interactable = false;
            lukplus.interactable = false;
        }
            dexmin.interactable = true;
    }
    public void DexterityMin()
    {
        if(attr >= 0 && attrConfirm == 1)
        {
            dex -= 1;
            attr += 1;
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
        }
        if(attr == attrFlag || dex == dexFlag)
        {
            dexmin.interactable = false;
        }
    }
    public void IntelligencePlus()
    {
        if(intel != 20)
        {
        intel += 1;
        attr -= 1;
        manaMax += 5;
        }
        attrConfirm = 1;
        if(attr == 0)
        {
        strplus.interactable = false;
        vitplus.interactable = false;
        dexplus.interactable = false;
        intplus.interactable = false;
        chaplus.interactable = false;
        lukplus.interactable = false;
        }
        intmin.interactable = true;
    }
    public void IntelligenceMin()
    {
        if(attr >= 0 && attrConfirm == 1)
        {
            manaMax -= 5;
            intel -= 1;
            attr += 1;
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
        }
        if(attr == attrFlag || intel == intFlag)
        {
            intmin.interactable = false;
        }
    }
    public void CharismaPlus()
    {
        if(cha != 20)
        {
        cha += 1;
        attr -= 1;
        }
        attrConfirm = 1;
        if(attr == 0)
        {
        strplus.interactable = false;
        vitplus.interactable = false;
        dexplus.interactable = false;
        intplus.interactable = false;
        chaplus.interactable = false;
        lukplus.interactable = false;
        }
        chamin.interactable = true;
    }
    public void CharismaMin()
    {
        if(attr >= 0 && attrConfirm == 1)
        {
            cha -= 1;
            attr += 1;
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
        }
        if(attr == attrFlag || cha == chaFlag)
        {
            chamin.interactable = false;
        }
    }
    public void LuckPlus()
    {
        if(luk != 20)
        {
        luk += 1;
        attr -= 1;
        }
        attrConfirm = 1;
        if(attr == 0)
        {
        strplus.interactable = false;
        vitplus.interactable = false;
        dexplus.interactable = false;
        intplus.interactable = false;
        chaplus.interactable = false;
        lukplus.interactable = false;
        }
        lukmin.interactable = true;
    }
    public void LuckMin()
    {
        if(attr >= 0 && attrConfirm == 1)
        {
            luk -= 1;
            attr += 1;
            strplus.interactable = true;
            vitplus.interactable = true;
            dexplus.interactable = true;
            intplus.interactable = true;
            chaplus.interactable = true;
            lukplus.interactable = true;
        }
        if(attr == attrFlag || luk == lukFlag)
        {
            lukmin.interactable = false;
        }
    }

}



