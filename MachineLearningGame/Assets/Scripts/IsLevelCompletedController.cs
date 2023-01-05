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
    public TMP_Dropdown dropDownMenu1;
    public Button playButton;
    public TextMeshProUGUI destroyedObjectsText;
    public TextMeshProUGUI destroyedObjects1Text;
    public TextMeshProUGUI destroyedObjects2Text;
    public TextMeshProUGUI destroyedObjects3Text;
    public GameObject runCompletePanel;
    public bool hasThree;
    public bool hasOne;
    public bool isLevel5;
    public bool hasTrash;
    public AudioSource _asWin;
    public int dropdownMenuValue;

    public List<Button> Buttons;
    void Start()
    {
        playButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLevel5)
        {
            if (Lines[0].GetComponent<LineButtons>().line.enabled && Lines[1].GetComponent<LineButtons>().line.enabled && Lines[2].GetComponent<LineButtons>().line.enabled && dropDownMenu.value == dropdownMenuValue && dropDownMenu1.value == 3)
            {
                
                playButton.interactable = true;
                

            }
            else
            {
                playButton.interactable = false;
            }
        }

        else
        {
            if (Lines[0].GetComponent<LineButtons>().line.enabled && Lines[1].GetComponent<LineButtons>().line.enabled && Lines[2].GetComponent<LineButtons>().line.enabled && dropDownMenu.value == dropdownMenuValue)
            {
               
                playButton.interactable = true;
                

            }
            else
            {
                playButton.interactable = false;
            }
        }
      

        if (hasOne && destroyedObjectsText.text == 10.ToString())
        {
            runCompletePanel.SetActive(true);
        }
        else
        {
            if (destroyedObjects1Text.text == 10.ToString() && destroyedObjectsText.text == 10.ToString() && !isLevel5 && !hasTrash)
            {
                runCompletePanel.SetActive(true);
            }
            if (isLevel5 && destroyedObjects1Text.text == 10.ToString() && destroyedObjectsText.text == 10.ToString() && destroyedObjects2Text.text == 5.ToString() && destroyedObjects3Text.text == 5.ToString())
            {
                runCompletePanel.SetActive(true);
            }
            if (hasTrash && destroyedObjects1Text.text == 10.ToString() && destroyedObjectsText.text == 10.ToString() && destroyedObjects2Text.text == 10.ToString())
            {
                runCompletePanel.SetActive(true);
            }
        }

        
    }

    public void PlayButtonClick()
    {
        _asWin.Play();
        PlayerPrefs.SetInt("isStart", 1);
        //Lines[0].GetComponent<Spawner>().enabled = true;
        // Spawner2.GetComponent<Spawner>().enabled = true;
        
        if (hasThree)
        {
            Spawner3.GetComponent<Spawner>().enabled = true;
        }

        foreach (var item in Buttons)
        {
            item.interactable = false;
        }
    }
}
