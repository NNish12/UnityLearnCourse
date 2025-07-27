using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Cube cube;
    [SerializeField] private Toggle toggleRainbow;
    [SerializeField] private Toggle toggleRotation;
    [SerializeField] private Slider sliderSpeedRainbow;
    [SerializeField] private Slider sliderSpeedRotation;
    [SerializeField] private Slider sliderTransparent;

    [SerializeField] private Slider sliderScale;
    [SerializeField] private TMP_Dropdown colorList;

    private bool onRainbow = true;
    private bool onRotation = true;
    private List<string> namesOptions = new List<string> { "Rainbow", "Black", "White", "Blue", "Red", "Green", "Yellow" };

    private void Start()
    {
        SetListeners();

        colorList.ClearOptions();
        SetNamesDropdown();
    }

    private void SetListeners()
    {
        toggleRainbow.onValueChanged.AddListener(SetRainbowState);
        toggleRotation.onValueChanged.AddListener(SetIsRotation);
        sliderSpeedRainbow.onValueChanged.AddListener(SetRainbowSpeed);
        sliderScale.onValueChanged.AddListener(SetScale);
        sliderSpeedRotation.onValueChanged.AddListener(SetRotationSpeed);
        sliderTransparent.onValueChanged.AddListener(SetTransparent);
        colorList.onValueChanged.AddListener(SetColor);
    }
    private void Update()
    {
        if (onRainbow)
        {
            cube.RainbowColor();
        }
        if (onRotation)
        {
            cube.CubeRotation();
        }
    }
    public void SetRainbowState(bool isOn)
    {
        onRainbow = isOn;
    }
    public void SetRainbowSpeed(float speed)
    {
        cube.speedRanbow = speed;
    }
    public void SetRotationSpeed(float speed)
    {
        cube.speedRotation = speed;
    }
    public void SetIsRotation(bool isOn)
    {
        onRotation = isOn;
    }
    public void SetScale(float scale)
    {
        cube.SetScale(scale);
    }
    public void SetColor(int index)
    {
        switch (index)
        {
            case 0:
                SetRainbowState(true);
                toggleRainbow.isOn = true;
                break;
            case 1:
                SetRainbowState(false);
                cube.SetSimpleColor(Color.black);
                break;
            case 2:
                SetRainbowState(false);
                cube.SetSimpleColor(Color.white);
                break;
            case 3:
                SetRainbowState(false);
                cube.SetSimpleColor(Color.blue);
                break;
            case 4:
                SetRainbowState(false);
                cube.SetSimpleColor(Color.red);
                break;
            case 5:
                SetRainbowState(false);
                cube.SetSimpleColor(Color.green);
                break;
            case 6:
                SetRainbowState(false);
                cube.SetSimpleColor(Color.yellow);
                break;
        }

    }
    private void SetNamesDropdown()
    {
        colorList.AddOptions(namesOptions);
    }
    private void SetTransparent(float transparent)
    {
        cube.alpha = transparent;
    }
}
