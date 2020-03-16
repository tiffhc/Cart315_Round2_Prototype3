using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public bool isDamaging;
    public float damage = 20f;

    public void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            col.gameObject.GetComponent<HealthBar>().TakeDamage(damage * Time.deltaTime);

            //col.SendMessage((isDamaging) ? "TakeDamage" : "HealthDamage", Time.deltaTime * damage);
        }
    }
}
