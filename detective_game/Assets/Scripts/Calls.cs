using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Calls : MonoBehaviour
{
    [SerializeField] InputField Number;
    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        if (Number.text == "97312")
        {
            audioSource.clip = clip1;
            audioSource.Play();
            Number.text = "";
        }
        else if (Number.text == "93766")
        {
            audioSource.clip = clip2;
            audioSource.Play();
            Number.text = "";
        }
        else if (Number.text == "95834")
        {
            audioSource.clip = clip3;
            audioSource.Play();
            Number.text = "";
        }
        else if (Number.text == "92674")
        {
            audioSource.clip = clip4;
            audioSource.Play();
            Number.text = "";
        }
        else if (Number.text == "97584")
        {
            audioSource.clip = clip5;
            audioSource.Play();
            Number.text = "«¿¡¬≈Õ»≈";
        }
        else if (Number.text == "43512")
        {
            audioSource.clip = clip6;
            audioSource.Play();
            Number.text = "œ–» ¿«";
        }
        else
        {
            audioSource.clip = clip7;
            audioSource.Play();
        }
    }
    public void OnNum1()
    {
        char a = '1';
        Number.text += a;
    }
    public void OnNum2()
    {
        char a = '2';
        Number.text += a;
    }
    public void OnNum3()
    {
        char a = '3';
        Number.text += a;
    }
    public void OnNum4()
    {
        char a = '4';
        Number.text += a;
    }
    public void OnNum5()
    {
        char a = '5';
        Number.text += a;
    }
    public void OnNum6()
    {
        char a = '6';
        Number.text += a;
    }
    public void OnNum7()
    {
        char a = '7';
        Number.text += a;
    }
    public void OnNum8()
    {
        char a = '8';
        Number.text += a;
    }
    public void OnNum9()
    {
        char a = '9';
        Number.text += a;
    }
    public void OnNum0()
    {
        char a = '0';
        Number.text += a;
    }
    public void OnNumz()
    {
        char a = '*';
        Number.text += a;
    }
    public void OnNumr()
    {
        char a = '#';
        Number.text += a;
    }
    public void Clearing()
    {
        Number.text = "";
    }
}
