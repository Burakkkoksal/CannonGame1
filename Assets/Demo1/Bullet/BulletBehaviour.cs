using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public ParticleSystem ExplodeEffect;//then drag explosion to bullet #2

   /* private void OnCollisionEnter(Collision collision)  #1
    {
        Debug.Log("OnCollisionEnter");

        //If there is no if platform can dissapear (targetprefab->tag->add..target untagged->Target)
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
        }

        
    }*/

    private void OnTriggerEnter(Collider other) //Box collider isTrigger ->check  #2
    {
        Debug.Log("OnTriggerEnter");     //#2

        //If there is no if platform can dissapear (targetprefab->tag->add..target untagged->Target)
        if (other.gameObject.tag == "Target")     //#2
        {
            ExplodeEffect.transform.parent = null; //Changes the particules' place

            ExplodeEffect.Play();

            Demo1.Instance.ScoreProperty++;//Update score and write on ui

            Destroy(other.gameObject);//#2
        }
    }
}
