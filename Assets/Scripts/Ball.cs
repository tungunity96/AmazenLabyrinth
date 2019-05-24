using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Ball : MonoBehaviour {
  public void Start()
  {
    var myPath = GetComponent<DOTweenPath>();
    var myPathTween = GetComponent<DOTweenPath>().tween;
    myPathTween.timeScale = 0f;
  }


}
