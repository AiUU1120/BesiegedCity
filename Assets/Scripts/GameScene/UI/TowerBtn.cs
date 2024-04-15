﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 组合控件 主要方便控制造塔相关UI的更新逻辑
/// </summary>
public class TowerBtn : MonoBehaviour
{
    public Image imgPic;

    public Text txtTip;

    public Text txtMoney;

    /// <summary>
    /// 初始化按钮信息的方法
    /// </summary>
    /// <param name="id"></param>
    /// <param name="inputStr"></param>
    public void InitInfo(int id, string inputStr)
    {
        TowerInfo info = GameDataMgr.Instance.towerInfoList[id - 1];
        imgPic.sprite = Resources.Load<Sprite>(info.imgRes);
        txtMoney.text = "￥" + info.money;
        txtTip.text = inputStr;
        //判断钱够不够
        //if (info.money > GameLevelMgr.Instance.player.money)
        //    txtMoney.text = "金钱不足";
    }
}
