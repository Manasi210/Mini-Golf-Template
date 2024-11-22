using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTeleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Player.transform.SetPositionAndRotation(TeleportPosition.transform.position,Quaternion.identity);
        }
    }
}
