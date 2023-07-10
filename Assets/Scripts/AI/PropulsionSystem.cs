using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



[RequireComponent(typeof(NavigationSystem))]
public class PropulsionSystem : MonoBehaviour
{

    [SerializeField] private NavigationSystem naviSystem;
    
    [SerializeField] private float speed;
    [SerializeField] private float speedMultiplier;
    
   
    [SerializeField] private float xRotationSpeed;
    [SerializeField] private float yRotationSpeed;

    [SerializeField] private float xRotationLimit;


    void Start()
    {
        naviSystem = GetComponent<NavigationSystem>();
    }
    

    void Update()
    {
        HandleTurning();
        Move();
    }
    
    private void Move()
    {
        this.gameObject.transform.Translate(Vector3.forward * (speed * speedMultiplier * Time.deltaTime));
    }

    private void HandleTurning()
    {
        var euler = transform.rotation.eulerAngles;
        
        var angleY = naviSystem.CorrectionAngleOnY();

        var angleX = naviSystem.CorrectionAngleOnX();

        if (euler.y is >= 270 and < 360 or >= 0 and <= 90)
        {
            angleX = -angleX;
        }

        angleX = Mathf.Clamp(angleX, -xRotationSpeed, xRotationSpeed);
        angleY = Mathf.Clamp(angleY, -yRotationSpeed, yRotationSpeed);
        
        var x = euler.x + angleX;
        var y = euler.y + angleY; 
        var z = 0;

        

        if (euler.x > 180 && euler.x < 360 - xRotationLimit)
        {
            x = 360 - xRotationLimit;
        }
        else if (x < 180 && x > xRotationLimit)
        {
            x = xRotationLimit;
        }

        this.gameObject.transform.eulerAngles = new Vector3(x, y, z);
        
    }

    
}
