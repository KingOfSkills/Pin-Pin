using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private GameObject pin;
    [SerializeField] private GameObject rotator;
    [SerializeField] private InputField playerName;
    [SerializeField] private Dropdown pinColorDropdown;
    [SerializeField] private Dropdown rotatorColorDropdown;
    [SerializeField] private Slider rotatorSlider;
    [SerializeField] private Text rotateSpeedText;
    [SerializeField] private Slider pinSlider;
    [SerializeField] private Text pinSpeedText;

    private int rotatorColorDropdownValue;
    private int pinColorDropdownValue;

    private void Awake()
    {
        //Keep data in Options the same as before.
        playerName.text = DataManager.player_Name;
        rotatorSlider.value = DataManager.rotateSpeed;
        pinSlider.value = DataManager.pinSpeed;
        //Trying to keep dropdown bar values. (Not Working)
        rotatorColorDropdown.value = rotatorColorDropdownValue;
        pinColorDropdown.value = pinColorDropdownValue;
    }
    public void UpdateName()
    {
        DataManager.player_Name = playerName.text;
    }
    public void RotatorColor()
    {
        switch (rotatorColorDropdown.value)
        {
            case 0:
                DataManager.rotator_Color = Color.black;
                rotator.GetComponent<SpriteRenderer>().color = DataManager.rotator_Color;
                break;
            case 1:
                DataManager.rotator_Color = Color.red;
                rotator.GetComponent<SpriteRenderer>().color = DataManager.rotator_Color;
                break;
            case 2:
                DataManager.rotator_Color = Color.yellow;
                rotator.GetComponent<SpriteRenderer>().color = DataManager.rotator_Color;
                break;
            case 3:
                DataManager.rotator_Color = Color.green;
                rotator.GetComponent<SpriteRenderer>().color = DataManager.rotator_Color;
                break;
            case 4:
                DataManager.rotator_Color = Color.cyan;
                rotator.GetComponent<SpriteRenderer>().color = DataManager.rotator_Color;
                break;
            case 5:
                DataManager.rotator_Color = Color.blue;
                rotator.GetComponent<SpriteRenderer>().color = DataManager.rotator_Color;
                break;
            case 6:
                DataManager.rotator_Color = Color.magenta;
                rotator.GetComponent<SpriteRenderer>().color = DataManager.rotator_Color;
                break;
        }
        rotatorColorDropdownValue = rotatorColorDropdown.value;
    }
    public void PinColor()
    {
        switch (pinColorDropdown.value)
        {
            case 0:
                DataManager.pin_Color = Color.black;
                pin.GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
                break;
            case 1:
                DataManager.pin_Color = Color.red;
                pin.GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
                break;
            case 2:
                DataManager.pin_Color = Color.yellow;
                pin.GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
                break;
            case 3:
                DataManager.pin_Color = Color.green;
                pin.GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
                break;
            case 4:
                DataManager.pin_Color = Color.cyan;
                pin.GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
                break;
            case 5:
                DataManager.pin_Color = Color.blue;
                pin.GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
                break;
            case 6:
                DataManager.pin_Color = Color.magenta;
                pin.GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
                break;
        }
        pinColorDropdownValue = pinColorDropdown.value;
    }
    public void RotatorSpeed()
    {
        DataManager.rotateSpeed = (int)rotatorSlider.value;
        rotator.GetComponent<Rotator>().speed = DataManager.rotateSpeed;
        rotateSpeedText.text = DataManager.rotateSpeed.ToString();
    }
    public void PinSpeed()
    {
        DataManager.pinSpeed = (int)pinSlider.value;
        pin.GetComponent<Pin1>().speed = DataManager.pinSpeed;
        pinSpeedText.text = DataManager.pinSpeed.ToString();
    }
}
