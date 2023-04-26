using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _text;

    private DataEnemy _dataEnemy;

    void Update()
    {
        string textData = $"{_dataEnemy.Health}";
        _text.text = textData;
    }
}
