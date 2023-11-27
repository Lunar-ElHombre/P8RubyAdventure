using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

              
            }            
        }
    }
}
