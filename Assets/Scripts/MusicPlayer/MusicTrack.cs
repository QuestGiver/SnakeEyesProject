using System;
using UnityEngine;

namespace MusicPlayer
{
    [Serializable]
    public class MusicTrack
    {
        public string id;
        public AudioClip[] clips;
    }
}