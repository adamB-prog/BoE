using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IWeaponMode
{
    public int CooldownTime { get; }
    void Shoot(List<RawImage> indicators, List<GameObject> projectileSpawners, GameObject blast, Color inActive, Color active);

    IWeaponMode ChangeState();

    void ResetIndicators(List<RawImage> indicators, Color inActive, Color active);
}
