﻿using UnityEngine;

// プレイヤーを制御するコンポーネント
public class Player : MonoBehaviour
{
    public float m_speed; // 移動の速さ

    // 毎フレーム呼び出される関数
    private void Update()
    {
        // 矢印キーの入力情報を取得する
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        // 矢印キーが押されている方向にプレイヤーを移動する
        var velocity = new Vector3(h, v) * m_speed;
        transform.localPosition += velocity;
    }
}
