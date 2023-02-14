using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SkipCinematicBehaviour : MonoBehaviour
{
    [SerializeField] private PlayableDirector timeline;
    [SerializeField] private List<float> jumpToSeconds;
    [SerializeField] private int index = 0;

    private void FixedUpdate()
    {
        bool isSkippedPressed = InputManager.GetInstance().GetEscapePressed();
        
        if (isSkippedPressed)
        {
            timeline.time = jumpToSeconds[index++];
        }
        
    }
}
