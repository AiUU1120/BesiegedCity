using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKMusic : MonoBehaviour
{
    private static BKMusic instance;
    public static BKMusic Instacne => instance;

    private AudioSource bkSource;

    void Awake()
    {
        instance = this;

        bkSource = this.GetComponent<AudioSource>();

        //通过数据来设置音乐的大小和开关
        MusicData data = GameDataMgr.Instance.musicData;
        SetIsOpen(data.musicOpen);
        ChangeValue(data.musicValue);
    }

    /// <summary>
    /// 开关背景音乐的方法
    /// </summary>
    /// <param name="isOpen"></param>
    public void SetIsOpen(bool isOpen)
    {
        bkSource.mute = !isOpen;
    }

    /// <summary>
    /// 调整被背景音乐大小的方法
    /// </summary>
    /// <param name="v"></param>
    public void ChangeValue(float v)
    {
        bkSource.volume = v;
    }
}
