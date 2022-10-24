using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    private const float frequency = 1f;

    public GameObject Target;
    
    void Start()
    {
        StartCoroutine(InstantiateTargets());
    }

    //Ienumerator for recursive
    IEnumerator InstantiateTargets()
    {
        //var yieldReturn = new WaitForSeconds(frequency);

        while (true) //Instantiate command
        {                                        //min,max
            var frequency = UnityEngine.Random.Range(0.5f, 1f);


            yield return new WaitForSeconds(frequency);

            Debug.Log("Instantiate");//control
                               //Instantiator position
            Instantiate(Target,transform.position,Quaternion.identity);

        }

    }
}
