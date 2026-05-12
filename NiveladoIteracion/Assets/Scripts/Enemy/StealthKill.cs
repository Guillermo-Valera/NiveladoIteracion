using System;
using UnityEngine;

public class StealthKill : MonoBehaviour
{
   
   [SerializeField] Health health;
   [SerializeField] private EnemyController enemyController;
   
   private void OnTriggerStay(Collider other)
   {
       if (!other.gameObject.CompareTag("Player")) return;
       
       if (Input.GetKeyDown(KeyCode.E))
       {
           Debug.Log("kill");
           health.TakeDamage(1000);
       }
   }

}
