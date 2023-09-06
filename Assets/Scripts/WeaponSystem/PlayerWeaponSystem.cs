
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeaponSystem : MonoBehaviour, IWeaponSystem
{
    [SerializeField] private List<RawImage> indicators;
    
    [SerializeField] private List<GameObject> projectileSpawners;

    [SerializeField] private GameObject blastPrefab;

    [SerializeField] private Color activeColor;

    [SerializeField] private Color inActiveColor;

    private IWeaponMode _weaponMode;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _weaponMode = new SingleFireWeaponMode();
        _weaponMode.ResetIndicators(indicators, inActiveColor, activeColor);
    }

    public void Shoot()
    {
        _weaponMode.Shoot(indicators, projectileSpawners, blastPrefab, inActiveColor, activeColor);
    }

    public void ChangeState()
    {
        _weaponMode = _weaponMode.ChangeState();
    }
}
