using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour            
{
    public GameObject Bullet;        // #1

    public Transform ReferencePositionOfBullet;  //#1

    public float Velocity;//public because i'll set it in unity editor   //#1

    //Main funcionality of this object
    public void Throw()          //#1
    {
        Debug.Log("Throw");//control    //#1

        //Instantiate has 10 overloads---------------------------------------//Default rotation
        var bullet = Instantiate(Bullet, ReferencePositionOfBullet.position, Quaternion.identity);//#1 Create game object from prefab.Returns gameobject

        //fetch rigidbody
        var rgb = bullet.GetComponent<Rigidbody>();    //#1

        rgb.AddForce(-Vector3.forward * Velocity, ForceMode.Force);  //#1

        
    }
}
