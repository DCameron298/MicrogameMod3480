using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickup : MonoBehaviour
{
     public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
  {
     RubyController controller = other.GetComponent<RubyController>();

     if (controller != null)
     {
          controller.ChangeSpeed();
          Destroy(gameObject);
          controller.PlaySound(collectedClip);
     }
}
}
