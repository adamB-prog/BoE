
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeaponSystem : MonoBehaviour, IWeaponSystem
{
    [SerializeField] private List<RawImage> indicators;
    
    [SerializeField] private List<Transform> projectileSpawners;

    [SerializeField] private Color activeColor;

    [SerializeField] private Color inActiveColor;

    private IWeaponMode _weaponMode;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _weaponMode = new SingleFireWeaponMode();
        _weaponMode.Reset(indicators, inActiveColor, activeColor);
    }

    public void Shoot()
    {
        _weaponMode.Shoot(indicators, projectileSpawners, inActiveColor, activeColor);
    }

    public void ChangeState()
    {
        _weaponMode = _weaponMode.ChangeState();
    }
}
