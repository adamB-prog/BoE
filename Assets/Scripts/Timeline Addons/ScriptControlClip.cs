using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class ScriptControlClip : PlayableAsset, ITimelineClipAsset
{
    [SerializeField] private ScriptControlBehaviour template = new ScriptControlBehaviour();
    
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        return ScriptPlayable<ScriptControlBehaviour>.Create(graph, template);
    }

    public ClipCaps clipCaps { get; }
}
