using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class AnimatorControlClip : PlayableAsset, ITimelineClipAsset
{
    [SerializeField] private AnimatorControlBehaviour template = new AnimatorControlBehaviour();
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        return ScriptPlayable<AnimatorControlBehaviour>.Create(graph, template);
    }

    public ClipCaps clipCaps { get; }
}
