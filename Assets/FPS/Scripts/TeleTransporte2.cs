using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleTransporte2 : MonoBehaviour
{
    public Transform Target2;
    public GameObject ThePlayer;

    private void OnTriggerEnter(Collider other) => ThePlayer.transform.position = Target2.transform.position;
}
