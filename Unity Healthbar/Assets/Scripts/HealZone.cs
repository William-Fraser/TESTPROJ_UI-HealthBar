using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;


public class HealZone : MonoBehaviour
{
    public GameObject player;
    private ThirdPersonUserControl playerControl;
    private bool active;

    private void Start()
    {
        playerControl = player.GetComponent<ThirdPersonUserControl>();
        active = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        active = true;
        StartCoroutine("Heal");
    }

    private void OnCollisionExit(Collision collision)
    {
        active = false;
        StopCoroutine("Heal");
    }

    IEnumerator Heal()
    {
        while (active)
        {
            playerControl.Heal(2);
        }
        yield return new WaitForSeconds(0.10f);
    }
}
