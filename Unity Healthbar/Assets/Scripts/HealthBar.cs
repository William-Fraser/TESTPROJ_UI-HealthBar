using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class HealthBar : MonoBehaviour
{
    //variables
    public GameObject player;
    private ThirdPersonUserControl playerControl;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        playerControl = player.GetComponent<ThirdPersonUserControl>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = playerControl.Health;
    }
}
