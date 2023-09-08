
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeaponSystem : MonoBehaviour, IWeaponSystem
{
    [SerializeField] private List<RawImage> indicators;
    
    [SerializeField] private List<GameObject> projectileSpawners;

    [SerializeField] private GameObject blastPrefab;

    [SerializeField] private Color activeColor;

    [SerializeField] private Color inActiveColor;

    [SerializeField] private AudioClip laserBlasterSoundClip;
    [SerializeField] private AudioClip changeWeaponStateSoundClip;

    [SerializeField] private AudioSource soundPlayer;

    private IWeaponMode _weaponMode;
    
    private bool _canShoot = true;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _weaponMode = new SingleFireWeaponMode();
        _weaponMode.ResetIndicators(indicators, inActiveColor, activeColor);
    }

    public void Shoot()
    {
        if(!_canShoot) return;
        
        soundPlayer.PlayOneShot(laserBlasterSoundClip);
        _weaponMode.Shoot(indicators, projectileSpawners, blastPrefab, inActiveColor, activeColor);

        Cooldown(_weaponMode.CooldownTime);
    }

    public void ChangeState()
    {
        soundPlayer.PlayOneShot(changeWeaponStateSoundClip);
        _weaponMode = _weaponMode.ChangeState();
        _weaponMode.ResetIndicators(indicators, inActiveColor, activeColor);
    }
    
    private void Cooldown(int ms)
    {
        _canShoot = false;
        Task.Run(async () =>
        {
            await Task.Delay(ms);
            _canShoot = true;
        });
    
    
    }
}
