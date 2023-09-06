using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class BlastBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;

     void Start()
     {
         Task.Run(async () =>
         {
             await Task.Delay(5000);
             Destroy(this.gameObject);
         });
     }

    void Update()
    {
        gameObject.transform.Translate(Vector3.right * (speed * Time.deltaTime), Space.Self);
    }
}
