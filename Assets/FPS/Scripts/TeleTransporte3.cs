using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleTransporte3 : MonoBehaviour
{
    public Transform Target3;
    public GameObject ThePlayer;

    private void OnTriggerEnter(Collider other) => ThePlayer.transform.position = Target3.transform.position;
}
