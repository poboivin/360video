﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoData2 : ScriptableObject
{

    [System.Serializable]
    public class Choices
    {
        [TextArea(3, 20)]
        public string ChoiceText;
        public int ChoiceClips;
    }
    [System.Serializable]
    public class Video
    {
        public VideoClip mainClip;
        public Choices[] choices;
    }

    public Video[] video;
}
