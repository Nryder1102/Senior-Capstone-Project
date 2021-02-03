using System.Collections;
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
    public static int cconfirm2 = 0;
    public GameObject classSelectUI;
    public GameObject barsUI;
    public GameObject statusUI;
    public GameObject skillUI;
    public GameObject menuUI;
    public static float waitVal;
    public static int waitFlag;
    public int menuState = 0;

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
        classSelectUI.SetActive(false);
        barsUI.SetActive(false);
        skillUI.SetActive(false);
        statusUI.SetActive(false);
        menuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        


        if(Input.GetKeyDown(KeyCode.Return))
        {
            classSelectUI.SetActive(true);
        }
        if (waitFlag == 1)
        {
            classSelectUI.SetActive(false);
            barsUI.SetActive(true);
            waitFlag = 0;
        }
        if (cconfirm2 == 1)
        {
            cconfirm.interactable = true;
        }


        MenuStateToggle();
    }

    //Controls what buttons choose which class
    public void ClassStart()
    {
        classSelectUI.SetActive(true);
    }

    //Chooses which class you select
    public void ClassSelect1()
    {
        classnum = 1;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
        
    }
    public void ClassSelect2()
    {
        classnum = 2;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }

    }
    public void ClassSelect3()
    {
        classnum = 3;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
    }
    public void ClassSelect4()
    {
        classnum = 4;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
    }
    public void ClassSelect5()
    {
        classnum = 5;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
    }
    public void ClassSelect6()
    {
        classnum = 6;
        if (cconfirm2 == 0)
        {
            cconfirm2 = 1;
        }
    }

    //Disables class confirm button, starts wait for class select to disappear
    public void ConfirmClass()
    {
        BttnDisable();
        cconfirm.interactable = false;
        waitVal = 5;
        StartCoroutine(WaitRoutine());
  
    }
    
    //Disables other class selections
    public void BttnDisable()
    {
       
        if (classnum == 1)
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
        
        
    }


    //Opens Menu
    public void OpenMenu()
    {
        statusUI.SetActive(true);
        menuState = 1;
    }

    public void CloseMenu()
    {
        statusUI.SetActive(false);
        menuState = 0;
    }

    //Wait function, for variable waitVal
    IEnumerator WaitRoutine()
    {
        yield return new WaitForSeconds(waitVal);
        waitFlag = 1;
    }

    public void MenuStateToggle()
{

    if(Input.GetKeyDown(KeyCode.Escape) && menuState == 0)
        {
            OpenMenu();
        }
    if(Input.GetKeyDown(KeyCode.Escape) && menuState == 1)
        {
            //CloseMenu();
        }

}

}
