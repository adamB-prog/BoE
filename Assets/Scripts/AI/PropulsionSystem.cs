using System;
using UnityEngine;

public interface INavigationSystem
{
    float CorrectionAngleOnY();
    float CorrectionAngleOnX();
}

public class PropulsionSystem : MonoBehaviour
{
    private INavigationSystem naviSystem;
    [SerializeField] private float speed;
    [SerializeField] private float speedMultiplier;
    [SerializeField] private float xRotationSpeed;
    [SerializeField] private float yRotationSpeed;
    [SerializeField] private float xRotationLimit;

    private void Start()
    {
        naviSystem = GetComponent<INavigationSystem>();
    }

    private void Update()
    {
        HandleTurning();
        Move();
    }

    public void SetNavigationSystem(INavigationSystem navigationSystem)
    {
        naviSystem = navigationSystem;
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * (speed * speedMultiplier * Time.deltaTime));
    }

    public void HandleTurning()
    {
        var euler = transform.rotation.eulerAngles;

        var angleY = naviSystem.CorrectionAngleOnY();
        var angleX = naviSystem.CorrectionAngleOnX();

        if ((euler.y >= 270 && euler.y < 360) || (euler.y >= 0 && euler.y <= 90))
        {
            angleX = -angleX;
        }

        angleX = Mathf.Clamp(angleX, -xRotationSpeed, xRotationSpeed);
        angleY = Mathf.Clamp(angleY, -yRotationSpeed, yRotationSpeed);

        var x = euler.x + angleX;
        var y = euler.y + angleY;
        var z = 0f;

        if (euler.x > 180 && euler.x < 360 - xRotationLimit)
        {
            x = 360 - xRotationLimit;
        }
        else if (x < 180 && x > xRotationLimit)
        {
            x = xRotationLimit;
        }

        transform.eulerAngles = new Vector3(x, y, z);
    }
}