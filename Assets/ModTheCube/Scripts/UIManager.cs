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


    private Color[] simpleColors = new Color[] { Color.black, Color.white, Color.blue, Color.red, Color.green, Color.yellow };

    private void Start()
    {
        SetListeners();

        colorList.ClearOptions();
        colorList.AddOptions(namesOptions);
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
        if (onRainbow == isOn) return;
        toggleRainbow.isOn = isOn;
        onRainbow = isOn;
        if (isOn == true)
        {
            cube.RainbowColor();
            if (colorList.value != 0)
                colorList.value = 0;
        }
    }
    public void SetRainbowSpeed(float speed)
    {
        cube.SpeedRainbow = speed;
    }
    public void SetRotationSpeed(float speed)
    {
        cube.SpeedRotation = speed;
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
        if (index == 0)
        {
            SetRainbowState(true);
            return;
        }
        SetRainbowState(false);
        cube.SetSimpleColor(simpleColors[index - 1]);
    }
    private void SetTransparent(float transparent)
    {
        cube.SetTransparent(transparent);
    }
}
