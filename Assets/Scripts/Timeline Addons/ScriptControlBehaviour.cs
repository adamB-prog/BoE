using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class ScriptControlBehaviour : PlayableBehaviour
{
    [SerializeField] private bool enabled;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        var script = playerData as MonoBehaviour;

        if (script == null)
        {
            return;
        }

        script.enabled = enabled;

    }
}
