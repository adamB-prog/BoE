
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SingleFireWeaponMode : IWeaponMode
{
    private int _index = 0;

    private bool _canShoot = true;
    public void Shoot(List<RawImage> indicators, List<Transform> projectileSpawners, Color inActive, Color active)
    {
        if (!_canShoot) return;
        
        
        
        switch (_index)
        {
            case 0:
                indicators[0].color = inActive;
                indicators[1].color = active;
                _index = 1;
                break;
            case 1:
                indicators[1].color = inActive;
                indicators[2].color = active;
                _index = 2;
                break;
            case 2:
                indicators[2].color = inActive;
                indicators[3].color = active;
                _index = 3;
                break;
            case 3:
                indicators[3].color = inActive;
                indicators[0].color = active;
                _index = 0;
                break;
        }
        
        CoolDown();
    }

    public IWeaponMode ChangeState()
    {
        return this;
    }

    public void Reset(List<RawImage> indicators, Color inActive, Color active)
    {
        _index = 0;
        foreach (var indicator in indicators)
        {
            indicator.color = inActive;
        }

        indicators[0].color = active;
    }

    public void CoolDown()
    {
        _canShoot = false;
        Task.Run(async () =>
        {
            await Task.Delay(333);
            _canShoot = true;
        });


    }
}
