using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject controlledObject;
    
    [SerializeField] private bool controlEnabled = true;

    [SerializeField] private float sensitivity = 0.3f;
    [SerializeField] private float yRotationSpeed = 0.5f;
    [SerializeField] private float speedMultiplier = 10f;

    //For UI Binding
    [SerializeField] private Scrollbar healthBar;

    [SerializeField] private Scrollbar speedBar;

    //For Starting values
    [SerializeField] private float startHealth = 1.0f;

    [SerializeField] private float startSpeed = 1.0f;

    [SerializeField] private float xRotationLimit;
    
    [SerializeField] private float zRotationLimit;

    [SerializeField] private float rotationPerInputLimit;
    
    


    //actual in-game values
    public float Health
    {
        get => health;
        private set
        {
            if (value is >= 0.0f and <= 1.0f)
            {
                health = value;
                healthBar.size = health;
            }
            
        }
    }

    public float Speed
    {
        get => speed;
        private set
        {
            if (value is >= 0.5f and <= 1.0f)
            {
                speed = value;
                speedBar.size = speed;
            }

            
        }
    }

    private float health;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        Health = startHealth;
        Speed = startSpeed;
        healthBar.size = health;
        speedBar.size = speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!controlEnabled)
        {
            return;
        }

        HandleTurning();
        HandleRadarInput();
        HandleSpeedChange();
        HandleAttack();
       
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        controlledObject.transform.Translate(Vector3.forward * speed * speedMultiplier * Time.deltaTime);
    }

    private void HandleAttack()
    {
        bool isAttacking = InputManager.GetInstance().GetShootPressed();

        if (isAttacking)
        {
            //TODO shoot a projectile
        }
    }

    private void HandleSpeedChange()
    {
        float speedChange = InputManager.GetInstance().AccelarationChange();

        Speed += speedChange * Time.fixedDeltaTime;
        
    }

    private void HandleRadarInput()
    {
        bool isRadarToggle = InputManager.GetInstance().IsRadarPressed();

        //TODO make radar with secondary camera
    }

    private void HandleTurning()
    {
        Vector2 directionDelta = InputManager.GetInstance().GetMouseDelta() * sensitivity;

        float x = controlledObject.transform.eulerAngles.x;
        float y = controlledObject.transform.eulerAngles.y;
        float z = controlledObject.transform.eulerAngles.z;

        //Clamping the input
        z += Mathf.Clamp(-directionDelta.x, -rotationPerInputLimit, rotationPerInputLimit);


        x += Mathf.Clamp(-directionDelta.y, -rotationPerInputLimit, rotationPerInputLimit);

        //Clamping multiple rotation axies
        if (z > 180 && z < 360 - zRotationLimit)
            z = 360 - zRotationLimit;
        else if (z < 180 && z > zRotationLimit)
            z = zRotationLimit;

        if (x > 180 && x < 360 - xRotationLimit)
            x = 360 - xRotationLimit;
        else if (x < 180 && x > xRotationLimit)
            x = xRotationLimit;

        if (z < 180)
        {
            y += z * -yRotationSpeed;
        }
        else
        {
            y += (z - 360) * -yRotationSpeed;
        }
        
        
        //Apply the rotation
        controlledObject.transform.eulerAngles = new Vector3(x, y, z);




    }
}