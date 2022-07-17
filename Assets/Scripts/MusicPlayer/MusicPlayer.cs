using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MusicPlayer
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicPlayer : MonoBehaviour
    {
        private const float FADE_OUT_TIME = 3;
        [SerializeField]
        private List<MusicTrack> trackMap;
        
        private static MusicPlayer instance;

        private static Dictionary<string, AudioClip[]> tracks;
        private static AudioSource source;

        private bool playing;

        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
            }
            instance = this;
            DontDestroyOnLoad(this);
            
            tracks = trackMap.ToDictionary(track => track.id, track => track.clips);
            source = GetComponent<AudioSource>();
        }

        public void PlayTrackByName(string id)
        {
            if (!tracks.ContainsKey(id))
            {
                Debug.LogError($"Music player does not contain a track named {id}!");
                return;
            }

            instance.StartCoroutine(PlayPlaylist(tracks[id]));
        }

        private IEnumerator PlayPlaylist(AudioClip[] clips)
        {
            if (source.clip != null)
            {
                StartCoroutine(FadeOutCurrentTrack());
                yield return new WaitForSeconds(FADE_OUT_TIME);
                source.volume = 1;
            }
            playing = true;
            while (playing)
            {
                foreach (var clip in clips)
                {
                    source.clip = clip;
                    source.Play();
                    yield return new WaitForSeconds(clip.length);
                }
            }
        }

        private IEnumerator FadeOutCurrentTrack()
        {
            for (var t = FADE_OUT_TIME; t > 0; t -= Time.deltaTime)
            {
                source.volume = t / FADE_OUT_TIME;
                yield return null;
            }
            source.volume = 0;
        }

        private void OnDestroy()
        {
            StopAllCoroutines();
            playing = false;
        }
    }
}
