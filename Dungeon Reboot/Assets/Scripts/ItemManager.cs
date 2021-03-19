using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
 
    //For Stats
    public static int wpnatk = 0;
    public static int armdef = 0;
    public static int wpnatkp1;
    public static int wpnatkp2;
    public static int armdefp1;
    public static int armdefp2;

    //For the inventory system
    public static bool weapTab;
    public static bool armTab;
    public static bool miscTab;
    public static bool keyTab;
    public static int WeapEquipped;
    public static int ArmEquipped;  
    public GameObject slot1;  
    public static int slot1Indicator = 1;
    public GameObject slot2; 
    public static int slot2Indicator;
    public GameObject slot3;
    public static int slot3Indicator;
    public GameObject slot4;
    public static int slot4Indicator;
    public GameObject slot5;
    public static int slot5Indicator;
    public GameObject slot6;
    public static int slot6Indicator;
    public GameObject slot7;
    public static int slot7Indicator;
    public GameObject slot8;
    public static int slot8Indicator; 
    public GameObject slot9;
    public static int slot9Indicator;
    public GameObject slot10;
    public static int slot10Indicator;       

    public Sprite noSprite;
    public Sprite player1Indicator;
    public Sprite player2Indicator;
    public Sprite player3Indicator;


    //Variables for the shinies



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjectIndicator();
    }

    //Inventory Pages
    public void ObjectIndicator()
    {
        //Disable Indicators if none are there
        if(slot1Indicator == 0)
        {
            slot1.SetActive(false);
        }
        if(slot2Indicator == 0)
        {
            slot2.SetActive(false);
        }
        if(slot3Indicator == 0)
        {
            slot3.SetActive(false);
        }
        if(slot4Indicator == 0)
        {
            slot4.SetActive(false);
        }
        if(slot5Indicator == 0)
        {
            slot5.SetActive(false);
        }
        if(slot6Indicator == 0)
        {
            slot6.SetActive(false);
        }
        if(slot7Indicator == 0)
        {
            slot7.SetActive(false);
        }
        if(slot8Indicator == 0)
        {
            slot8.SetActive(false);
        }
        if(slot9Indicator == 0)
        {
            slot9.SetActive(false);
        }
        if(slot10Indicator == 0)
        {
            slot10.SetActive(false);
        }

        //Enable Player 1 Indicator
        if(slot1Indicator == 1)
        {
           this.slot1.GetComponent<Image>().overrideSprite = player1Indicator;
           slot1.SetActive(true);
        }
 
  
 
 
 
    }



    
    //Items list
    public void EquippedWeapons()
    {

    }

    public void EquippedArmor()
    {
        
    }


    //WEAPONS LIST STARTS HERE
    public void BrokenSword()
    {
        wpnatk = 2;
    }
    public void TrainingSword()
    {
        wpnatk = 5;
    }





    //ARMOR LIST STARTS HERE







    //MISC/CONSUMABLES START HERE





    //KEY ITEMS START HERE
}
