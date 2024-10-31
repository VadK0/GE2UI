using UnityEngine;
using UnityEngine.Audio;

public class SetLevel : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetMusicLevel(float sliderlevel)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderlevel)*20);
    }
}
