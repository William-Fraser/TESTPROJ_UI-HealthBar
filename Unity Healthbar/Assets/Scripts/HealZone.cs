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

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Heal")
        {
            StartCoroutine("Heal");
        }
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
