using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketController : MonoBehaviour
{
    [SerializeField] private GameObject basketCover;
    [SerializeField] private Text collectedCount;

    private int collectGoal;
    private int collectCount;
    private bool collectCompleted;
    private bool countDownStarts;


}
