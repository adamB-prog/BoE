using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject controlledObject;
    
    private IWeaponSystem _weaponSystem;

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
        get => _health;
        private set
        {
            if (value is >= 0.0f and <= 1.0f)
            {
                _health = value;
                healthBar.size = _health;
            }
        }
    }

    public float Speed
    {
        get => _speed;
        private set
        {
            if (value is >= 0.5f and <= 1.0f)
            {
                _speed = value;
                speedBar.size = _speed;
            }
        }
    }

    private float _health;
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _weaponSystem = GetComponent<IWeaponSystem>();
        Health = startHealth;
        Speed = startSpeed;
        healthBar.size = _health;
        speedBar.size = _speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!controlEnabled)
        {
            return;
        }

        HandleChangeFireMode();
        HandleRadarInput();
        HandleSpeedChange();
        HandleAttack();
    }

    void Update()
    {
        Move();
        HandleTurning();
    }

    private void Move()
    {
        controlledObject.transform.Translate(Vector3.forward * (_speed * speedMultiplier * Time.deltaTime));
    }

    private void HandleChangeFireMode()
    {
        if (InputManager.GetInstance().IsChangeWeaponStatePressed())
        {
            _weaponSystem.ChangeState();
        }
    }

    private void HandleAttack()
    {
        bool isAttacking = InputManager.GetInstance().GetShootPressed();

        if (isAttacking)
        {
            _weaponSystem.Shoot();
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

        var eulerAngles = controlledObject.transform.eulerAngles;
        float x = eulerAngles.x;
        float y = eulerAngles.y;
        float z = eulerAngles.z;

        //Clamping the input
        z += Mathf.Clamp(-directionDelta.x, -rotationPerInputLimit, rotationPerInputLimit);


        x += Mathf.Clamp(-directionDelta.y, -rotationPerInputLimit, rotationPerInputLimit);

        //Clamping multiple rotation axes
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
            y += z * -yRotationSpeed * Time.deltaTime;
        }
        else
        {
            y += (z - 360) * -yRotationSpeed * Time.deltaTime;
        }


        //Apply the rotation
        controlledObject.transform.eulerAngles = new Vector3(x, y, z);
    }
}
