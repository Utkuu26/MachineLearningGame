using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IsLevelCompletedController : MonoBehaviour
{
    public List<Button> Lines;
    public GameObject Spawner2;
    public GameObject Spawner3;
   // public Dropdown dropDownMenu;
    public TMP_Dropdown dropDownMenu;
    public Button playButton;
    public TextMeshProUGUI destroyedObjectsText;
    public TextMeshProUGUI destroyedObjects1Text;
    public GameObject runCompletePanel;
    public bool hasThree;
    public bool hasOne;
    public AudioSource _asWin;
    void Start()
    {
        playButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Lines[0].GetComponent<LineButtons>().line.enabled && Lines[1].GetComponent<LineButtons>().line.enabled && Lines[2].GetComponent<LineButtons>().line.enabled && dropDownMenu.value == 0)
        {
            _asWin.Play();
            playButton.interactable = true;
           
        }
        else
        {
            playButton.interactable = false;
        }

        if (hasOne && destroyedObjectsText.text == 10.ToString())
        {
            runCompletePanel.SetActive(true);
        }
        else
        {
            if (destroyedObjects1Text.text == 10.ToString() && destroyedObjectsText.text == 10.ToString())
            {
                runCompletePanel.SetActive(true);
            }
        }

        
    }

    public void PlayButtonClick()
    {
        Lines[0].GetComponent<Spawner>().enabled = true;
        Spawner2.GetComponent<Spawner>().enabled = true;
       
        if (hasThree)
        {
            Spawner3.GetComponent<Spawner>().enabled = true;
        }
    }
}
