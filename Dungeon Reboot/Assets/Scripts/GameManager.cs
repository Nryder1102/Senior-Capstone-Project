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
    public static int classnum = 0;
    public static int cconfirm2 = 0;
    public GameObject classSelectUI;
    public GameObject barsUI;
    public GameObject statusUI;
    public GameObject skillUI;
    public GameObject menuUI;
    public static float waitVal;
    public static int waitFlag;
    public int menuState = 0;
    public GameObject list;
    public GameObject confirmQuit;
    public static int selectedChar = 0;
    
    
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
        
        if(Input.GetKeyDown(KeyCode.Return) && classnum == 0)
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

        if(Input.GetKeyDown(KeyCode.Escape) && classnum != 0)
        {
            bool isActive = menuUI.activeSelf;
            menuUI.SetActive(!isActive);
            statusUI.SetActive(false);
            confirmQuit.SetActive(false);
            list.SetActive(true);
        }
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
        waitVal = 2;
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
        ClassManager.healthMax = ClassManager.healthMaxFlag;
        ClassManager.manaMax = ClassManager.manaMaxFlag;
        ClassManager.attrConfirm = 0;
        
    }
    public void CharSelect2()
    {
        selectedChar = 2;
        PartyManager.attrp1 = PartyManager.attrp1Flag;
        ClassManager.attrConfirm = 0;

    }
    public void CharSelect3()
    {
        selectedChar = 3;
        Debug.Log(selectedChar);
    }




}
