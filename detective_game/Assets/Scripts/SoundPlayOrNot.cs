using UnityEngine;
using UnityEngine.UI;
public class SoundPlayOrNot : MonoBehaviour
{
    public Sprite audioOn;
    public Sprite audioOff;
    public GameObject buttonAudio;
    public AudioSource audio;
    public AudioClip clip;
    public void OnOffAudio()
    {
        if(AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            buttonAudio.GetComponent<Image>().sprite = audioOff;
        }
        else
        {
            AudioListener.volume = 1;
            buttonAudio.GetComponent<Image>().sprite = audioOn;
        }
    }
}
