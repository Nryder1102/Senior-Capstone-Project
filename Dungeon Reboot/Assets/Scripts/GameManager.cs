﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Button roguebttn;
    public Button magebttn;
    public Button paladinbttn;
    public Button rangerbttn;
    public Button fighterbttn;
    public Button beastbttn;
    public Button cconfirm;
    public static int classnum;
    public static int cconfirm2;
/*
    public Sprite beastdisabled;
    public Sprite fighterdisabled;
    public Sprite rangerdisabled;
    public Sprite paladindisabled;
    public Sprite magedisabled;
    public Sprite roguedisabled;
    public Sprite beastdetails;
    public Sprite fighterdetails;
    public Sprite rangerdetails;
    public Sprite paladindetails;
    public Sprite magedetails;
    public Sprite roguedetails;
*/
    
    
    // Start is called before the first frame update
    void Start()
    {
        cconfirm.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void ClassSelect1()
    {
        classnum = 1;
        cconfirm2 = 1;
        cconfirm.interactable = true;
    }
    public void ClassSelect2()
    {
        classnum = 2;
        cconfirm2 = 1;
        cconfirm.interactable = true;
    }
    public void ClassSelect3()
    {
        classnum = 3;
        cconfirm2 = 1;
        cconfirm.interactable = true;
    }
    public void ClassSelect4()
    {
        classnum = 4;
        cconfirm2 =1;
        cconfirm.interactable = true;
    }
    public void ClassSelect5()
    {
        classnum = 5;
        cconfirm2 = 1;
        cconfirm.interactable = true;
    }
    public void ClassSelect6()
    {
        classnum = 6;
        cconfirm2 =1;
        cconfirm.interactable = true;
    }

    public void ConfirmClass()
    {
        BttnDisable();

    }
    public void BttnDisable()
    {
       
        if (classnum == 1 && cconfirm2 == 1)
        {
            magebttn.interactable = false;
            paladinbttn.interactable = false;
            rangerbttn.interactable = false;
            fighterbttn.interactable = false;
            beastbttn.interactable = false;
            cconfirm2 = 2;
        }
        if (classnum == 2)
        {
            roguebttn.interactable = false;
            paladinbttn.interactable = false;
            rangerbttn.interactable = false;
            fighterbttn.interactable = false;
            beastbttn.interactable = false;
            cconfirm2 = 2;
        }
        if (classnum == 3)
        {
            roguebttn.interactable = false;
            magebttn.interactable = false;
            rangerbttn.interactable = false;
            fighterbttn.interactable = false;
            beastbttn.interactable = false;
            cconfirm2 = 2;
        }
        if (classnum == 4)
        {
            roguebttn.interactable = false;
            magebttn.interactable = false;
            paladinbttn.interactable = false;
            fighterbttn.interactable = false;
            beastbttn.interactable = false;
            cconfirm2 = 2;
        }
        if (classnum == 5)
        {
            roguebttn.interactable = false;
            magebttn.interactable = false;
            paladinbttn.interactable = false;
            rangerbttn.interactable = false;
            beastbttn.interactable = false;
            cconfirm2 = 2;
        }
        if (classnum == 6)
        {
            roguebttn.interactable = false;
            magebttn.interactable = false;
            paladinbttn.interactable = false;
            rangerbttn.interactable = false;
            fighterbttn.interactable = false;
            cconfirm2 = 2;
            
        }
        cconfirm.interactable = false;

    }

}
