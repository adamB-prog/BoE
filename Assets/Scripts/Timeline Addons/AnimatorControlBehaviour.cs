using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class AnimatorControlBehaviour : PlayableBehaviour
{
    [SerializeField] private bool enabled;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        var animator = playerData as Animator;

        if (animator == null)
        {
            return;
        }

        animator.enabled = enabled;
    }
}
