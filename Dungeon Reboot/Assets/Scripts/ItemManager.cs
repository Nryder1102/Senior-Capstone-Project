using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

    public static int wpnatk = 0;
    public static int armdef = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EquippedWeapons()
    {

    }

    public void EquippedArmor()
    {
        
    }
    public void BrokenSword()
    {
        wpnatk = 2;
    }
    public void TrainingSword()
    {
        wpnatk = 5;
    }
}
