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




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
