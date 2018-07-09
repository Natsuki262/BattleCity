using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SO01 : MonoBehaviour {

    // スコアを表示する
    public Text scoreText;
    // ハイスコアを表示する
    public Text highScoreText;

    // スコア
    private int score;

    // ハイスコア
    private int highScore;

    // PlayerPrefsで保存するためのキー
    private string highScoreKey = "highScore";

    // 速度
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
        // Use this for initialization
        void Start()
        {
        Initialize();
    }

        // Update is called once per frame
        void Update()
        {

            // 移動処理
            Move();
        // スコアがハイスコアより大きければ
        if (highScore < score)
        {
            highScore = score;
        }

        // スコア・ハイスコアを表示する
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }

        // 移動関数
        void Move()
        {
            // 現在位置をPositionに代入
            Vector2 Position = transform.position;
            // 左キーを押し続けていたら
            if (Input.GetKey("left"))
            {
                // 代入したPositionに対して加算減算を行う
                Position.x -= SPEED.x;
            score = score + 1;
        }
            else if (Input.GetKey("right"))
            { // 右キーを押し続けていたら
              // 代入したPositionに対して加算減算を行う
                Position.x += SPEED.x;
            score = score + 1;
            }
            else if (Input.GetKey("up"))
            { // 上キーを押し続けていたら
              // 代入したPositionに対して加算減算を行う
                Position.y += SPEED.y;
            // ポイントの追加
      
   
            }
            else if (Input.GetKey("down"))
            { // 下キーを押し続けていたら
              // 代入したPositionに対して加算減算を行う
                Position.y -= SPEED.y;
          
        }
            // 現在の位置に加算減算を行ったPositionを代入する
            transform.position = Position;
        }
    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;

        // ハイスコアを取得する。保存されてなければ0を取得する。
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    

    // ハイスコアの保存
    public void Save()
    {
        // ハイスコアを保存する
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        // ゲーム開始前の状態に戻す
        Initialize();
    }

}
