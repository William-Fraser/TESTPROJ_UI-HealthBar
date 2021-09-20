using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class HealthBar : MonoBehaviour
{
    //variables
    public GameObject player;
    public GameObject barForColour;
    private ThirdPersonUserControl playerControl;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        playerControl = player.GetComponent<ThirdPersonUserControl>();
        barForColour.GetComponent<Image>().color = new Color32(100, 251, 5, 255);
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = playerControl.Health;
        if (slider.value == 100)
        {
            barForColour.GetComponent<Image>().color = new Color32(100, 251, 5, 255);
        }
        else if (slider.value == 75)
        {
            barForColour.GetComponent<Image>().color = new Color32(171, 231, 25, 255);
        }
        else if (slider.value == 50)
        {
            barForColour.GetComponent<Image>().color = new Color32(231, 208, 25, 255);
        }
        else if (slider.value == 25)
        {
            barForColour.GetComponent<Image>().color = new Color32(231, 137, 25, 255);
        }
        else if (slider.value == 10)
        {
            barForColour.GetComponent<Image>().color = new Color32(231, 50, 25, 255);
        }
    }
}
