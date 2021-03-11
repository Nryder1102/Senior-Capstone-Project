using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Class Select
    public Button roguebttn;
    public Button magebttn;
    public Button paladinbttn;
    public Button rangerbttn;
    public Button fighterbttn;
    public Button beastbttn;
    public Button cconfirm;
    public static int classnum = 0;
    public static int cconfirm2 = 0;

    //Individual UI Groups
    public GameObject classSelectUI;
    public GameObject barsUI;
    public GameObject statusUI;
    public GameObject skillUI;
    public GameObject menuUI;
    public GameObject invUI;
    public GameObject saveUI;
    public GameObject loadUI;

    //Wait Function variables
    public static float waitVal;
    public static int waitFlag;

    //Default state and opening and closing of menu
    public int menuState = 0;
    public GameObject list;

    //Well, confirm quitting the game
    public GameObject confirmQuit;

    //Status Screen
    public static int selectedChar = 0;
    public static string statPlayerName = "Name";
    public GameObject charPic1;
    public GameObject charPic2;
    public GameObject charPic3;

    //Character Creation
    public InputField playerName;
    public GameObject playerNameEntry;
    public Button playerNameConfirm;
    public static int playerRace;
    public static string playerRaceName;
    public GameObject playerRaceSelect;
    public GameObject playerCreation;
    public GameObject playerGenderSelect;
    public static string playerGender;
    public Button playerPronounConfirm;
    public Sprite egg1;

    //Inventory
    public static int objectPage = 1;
    public Button objectLeft;
    public Button objectRight;
    public static int currentTab;



    //Intro
    public GameObject introScene;







    
    
    // Start is called before the first frame update
    void Start()
    {
        cconfirm.interactable = false;
        classSelectUI.SetActive(false);
        barsUI.SetActive(false);
        skillUI.SetActive(false);
        statusUI.SetActive(false);
        menuUI.SetActive(false);
        invUI.SetActive(false);
        loadUI.SetActive(false);
        saveUI.SetActive(false);
        playerCreation.SetActive(true);
        playerNameEntry.SetActive(false);
        playerNameConfirm.interactable = false;
        playerPronounConfirm.interactable = false;
        objectLeft.interactable = false;
        introScene.SetActive(true);
        playerGenderSelect.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (waitFlag == 1)
        {
            barsUI.SetActive(true);
            waitFlag = 0;
        }
        if (cconfirm2 == 1)
        {
            cconfirm.interactable = true;
        }

        if(Input.GetKeyDown(KeyCode.Escape) && classnum != 0)
        {
            bool isActive = menuUI.activeSelf;
            menuUI.SetActive(!isActive);
            confirmQuit.SetActive(false);
            StatsBack();
            InvBack();
            objectPage = 1;
        }

        if(objectPage == 3)
        {
            objectRight.interactable = false;
        }
        if(objectPage != 3)
        {
            objectRight.interactable = true;
        }
        if(objectPage == 1)
        {
            objectLeft.interactable = false;
        }
        if(objectPage != 1)
        {
            objectLeft.interactable = true;
        }
    }

    //Controls what buttons choose which class
    public void ClassStart()
    {
        classSelectUI.SetActive(true);
    }

    public void NameEntryStart()
    {
        playerNameEntry.SetActive(true);
    }

    public void GenderEntryStart()
    {
        playerGenderSelect.SetActive(true);
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
        classSelectUI.SetActive(false);
        //For testing purposes
        playerNameEntry.SetActive(true);

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


    //Wait function, for variable waitVal
    IEnumerator WaitRoutine()
    {
        yield return new WaitForSeconds(waitVal);
        waitFlag = 1;
    }

    public void OpenStats()
    {
        list.SetActive(false);
        statusUI.SetActive(true);

    }
    public void OpenInventory()
    {
        list.SetActive(false);
        invUI.SetActive(true);

    }
    public void QuitConfirmation()
    {
        confirmQuit.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void QuitStop()
    {
        confirmQuit.SetActive(false);
    }

    public void StatsBack()
    {
            statusUI.SetActive(false);
            list.SetActive(true);
            ClassManager.str = ClassManager.strFlag;
            ClassManager.vit = ClassManager.vitFlag;
            ClassManager.dex = ClassManager.dexFlag;
            ClassManager.intel = ClassManager.intFlag;
            ClassManager.cha = ClassManager.chaFlag;
            ClassManager.luk = ClassManager.lukFlag;
            ClassManager.healthMax = ClassManager.healthMaxFlag;
            ClassManager.manaMax = ClassManager.manaMaxFlag;
            ClassManager.attr = ClassManager.attrFlag;
            ClassManager.attrConfirm = 0;
            PartyManager.strp1 = PartyManager.strp1Flag;
            PartyManager.vitp1 = PartyManager.vitp1Flag;
            PartyManager.dexp1 = PartyManager.dexp1Flag;
            PartyManager.intelp1 = PartyManager.intp1Flag;
            PartyManager.chap1 = PartyManager.chap1Flag;
            PartyManager.lukp1 = PartyManager.lukp1Flag;
            PartyManager.healthMaxp1 = PartyManager.healthMaxp1Flag;
            PartyManager.manaMaxp1 = PartyManager.manaMaxp1Flag;
            PartyManager.attrp1 = PartyManager.attrp1Flag;
            PartyManager.strp2 = PartyManager.strp2Flag;
            PartyManager.vitp2 = PartyManager.vitp2Flag;
            PartyManager.dexp2 = PartyManager.dexp2Flag;
            PartyManager.intelp2 = PartyManager.intp2Flag;
            PartyManager.chap2 = PartyManager.chap2Flag;
            PartyManager.lukp2 = PartyManager.lukp2Flag;
            PartyManager.healthMaxp2 = PartyManager.healthMaxp2Flag;
            PartyManager.manaMaxp2 = PartyManager.manaMaxp2Flag;
            PartyManager.attrp2 = PartyManager.attrp2Flag;
            selectedChar = 1;
    }
    public void InvBack()
    {
        invUI.SetActive(false);
        list.SetActive(true);  
    }

//These deal with the player name
    public void NameButton()
    {
        playerNameConfirm.interactable = !string.IsNullOrWhiteSpace(playerName.text);
    }
    public void NameConfirm()
    {
        playerNameConfirm.interactable = false;
        statPlayerName = playerName.text.ToString();
        playerNameEntry.SetActive(false);
        if(statPlayerName == "James " && classnum == 6 && playerGender == "male")
        {
            this.charPic1.GetComponent<Image>().overrideSprite = egg1;
            ClassManager.Egg1 = true;
            statPlayerName = "James";
            ClassManager.className = "Trainer";
        }
        waitVal = 2;
        StartCoroutine(WaitRoutine());
    }

//Here should handle player pronoun choice
    public void PronounChoice1()
    {
        playerGender = "male";
        playerPronounConfirm.interactable = true;
    }
    public void PronounChoice2()
    {
        playerGender = "female";
        playerPronounConfirm.interactable = true;
    }
    public void PronounChoice3()
    {
        playerGender = "nb";
        playerPronounConfirm.interactable = true;
    }
    public void PronounConfirm()
    {
        playerPronounConfirm.interactable = false;
        playerGenderSelect.SetActive(false);

        //For testing purposes
        classSelectUI.SetActive(true);
        Debug.Log(playerGender);
    }

    public void SelectRace1()
    {

    }
    public void SelectRace2()
    {
        
    }
    public void SelectRace3()
    {
        
    }
    public void SelectRace4()
    {
        
    }
    public void SelectRace5()
    {
        
    }
    public void SelectRace6()
    {
        
    }
    public void SaveRace()
    {
        
    }



//Changes which character slot is selected on the party menu
    public void CharSelect1()
    {
        selectedChar = 1;
        ClassManager.str = ClassManager.strFlag;
        ClassManager.vit = ClassManager.vitFlag;
        ClassManager.dex = ClassManager.dexFlag;
        ClassManager.intel = ClassManager.intFlag;
        ClassManager.cha = ClassManager.chaFlag;
        ClassManager.luk = ClassManager.lukFlag;
        ClassManager.healthMax = ClassManager.healthMaxFlag;
        ClassManager.manaMax = ClassManager.manaMaxFlag;
        ClassManager.attr = ClassManager.attrFlag;
        ClassManager.attrConfirm = 0;
        
    }
    public void CharSelect2()
    {
        selectedChar = 2;
        PartyManager.strp1 = PartyManager.strp1Flag;
        PartyManager.vitp1 = PartyManager.vitp1Flag;
        PartyManager.dexp1 = PartyManager.dexp1Flag;
        PartyManager.intelp1 = PartyManager.intp1Flag;
        PartyManager.chap1 = PartyManager.chap1Flag;
        PartyManager.lukp1 = PartyManager.lukp1Flag;
        PartyManager.healthMaxp1 = PartyManager.healthMaxp1Flag;
        PartyManager.manaMaxp1 = PartyManager.manaMaxp1Flag;
        PartyManager.attrp1 = PartyManager.attrp1Flag;
        ClassManager.attrConfirm = 0;
    }
    public void CharSelect3()
    {
        selectedChar = 3;
        PartyManager.strp2 = PartyManager.strp2Flag;
        PartyManager.vitp2 = PartyManager.vitp2Flag;
        PartyManager.dexp2 = PartyManager.dexp2Flag;
        PartyManager.intelp2 = PartyManager.intp2Flag;
        PartyManager.chap2 = PartyManager.chap2Flag;
        PartyManager.lukp2 = PartyManager.lukp2Flag;
        PartyManager.healthMaxp2 = PartyManager.healthMaxp2Flag;
        PartyManager.manaMaxp2 = PartyManager.manaMaxp2Flag;
        PartyManager.attrp2 = PartyManager.attrp2Flag;
        ClassManager.attrConfirm = 0;
    }

//Space where the "Voice in your Head" comments on your name, class, and race
    



    //Space to start making inventory management, using the items from item manager
    public void WeaponTab()
    {
        ItemManager.weapTab = true;
        ItemManager.armTab = false;
        ItemManager.miscTab = false;
        ItemManager.keyTab = false;
        objectPage = 1;
        currentTab = 1;
    }
    
    public void ArmorTab()
    {
        ItemManager.weapTab = false;
        ItemManager.armTab = true;
        ItemManager.miscTab = false;
        ItemManager.keyTab = false;
        objectPage = 1;
        currentTab = 2;
    }

    public void MiscTab()
    {
        ItemManager.weapTab = false;
        ItemManager.armTab = false;
        ItemManager.miscTab = true;
        ItemManager.keyTab = false;
        objectPage = 1;
        currentTab = 3;
    }

    public void KeyTab()
    {
        ItemManager.weapTab = false;
        ItemManager.armTab = false;
        ItemManager.miscTab = false;
        ItemManager.keyTab = true;
        objectPage = 1;
        currentTab = 4;
    }

    public void InvLeftArrow()
    {

        if(objectPage != 1)
        {
            objectLeft.interactable = true;
            objectPage -= 1;
        }
    }

    public void InvRightArrow()
    {
        if(objectPage != 3)
        {
            objectRight.interactable = true;
            objectPage += 1;
        }
    }


}
