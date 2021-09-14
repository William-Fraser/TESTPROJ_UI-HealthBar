using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Buttons : MonoBehaviour
{
    public GameObject player;
    private ThirdPersonUserControl playerControl;

    private int value = 5;

    private void Start()
    {
        playerControl = player.GetComponent<ThirdPersonUserControl>();
    }

    public void HealPlayer()
    {
        playerControl.Heal(value);
    }
    public void DamagePlayer()
    {
        playerControl.TakeDamage(value);
    }
}
