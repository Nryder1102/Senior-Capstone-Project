using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    //Variables that will be used in most scenes
    public string pName = GameManager.statPlayerName;
    public static string pGender = GameManager.playerGender;
    public string pRace = GameManager.playerRaceName;
    public string pClass = ClassManager.className; 
    public static string pSub;
    public static string pSubU;
    public static string pObj;
    public static string pObjU;
    public static string currentSpeaker;
    public static bool characterKnown;
    public GameObject dialogueBox;
    public Text dialogueText;
    public Text speakerName;

 
    //The meaty stuff

    public Queue<string> history;
    // Start is called before the first frame update
    void Start()
    {
        history = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Sets pronouns based on choice
    public void PronounTerms()
    {
        if(pGender == "male")
        {
            pSub = "he";
            pSubU = "He";
            pObj = "him";
            pObjU = "Him";
        }
        if(pGender == "female")
        {
            pSub = "she";
            pSubU = "She";
            pObj = "her";
            pObjU = "Her";
        }
        if(pGender == "nb")
        {
            pSub = "they";
            pSubU = "They";
            pObj = "them";
            pObjU = "Them";
        }
    }

    //Dialogue boxes start here
    public void IntroScene()
    {
        speakerName.text = "???";
        //Provide background on the world, tell stories of the 6 heroes and what's to come
        dialogueText.text = "Welcome, to the lands of (TBD), little one, a world of might and magic, wonder and weaponry, where heroes rise and empires fall.";
        //Then say none of that matters
        dialogueText.text = "Except, however, none of that matters to you, being stuck in this lightless prison as you are, recieving basic history lessons from the voices in your head.";
    }

    //Ask player to choose pronouns
    public void PronounScene()
    {
        dialogueText.text = "Well now, young one, starting to wake up are we?";
    }

    //Ask player to choose race
    public void RaceScene()
    {

    }

    //Ask player to choose class
    public void ClassScene()
    {

    }

    //Ask player to choose name
    public void NameScene()
    {

    }

    //Comment on players choices
    public void CommentScene()
    {
        speakerName.text = "???";
        //Comment on name, and class, basically confirming info unless it's an easter egg 
        dialogueText.text = "";

        //After the comment, before "Waking up"
        dialogueText.text = "Well, chop chop, you can't be lying here all day listening to make believe voices in your head, now can you? You've got work to do, and I hear something roaming around nearby, goodbye for now, little one.";
    }















    //Function to try and introduce characters
    public void UnknownCharacter()
    {

    }
}
