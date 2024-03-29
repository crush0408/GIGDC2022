using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public float BGMmasterSoundVolume;
    public float EFFmasterSoundVolume;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        Init();

        
        
    }

    private void Start()
    {
        MGSound.instance.BGMVol();
    }

    private void Init() // 초기화(초기 설정)
    {
        if (!PlayerPrefs.HasKey("BGM")) PlayerPrefs.SetFloat("BGM", 0.5f);
        BGMmasterSoundVolume = PlayerPrefs.GetFloat("BGM");

        if (!PlayerPrefs.HasKey("EFF")) PlayerPrefs.SetFloat("EFF", 0.5f);
        EFFmasterSoundVolume = PlayerPrefs.GetFloat("EFF");
    }
}
