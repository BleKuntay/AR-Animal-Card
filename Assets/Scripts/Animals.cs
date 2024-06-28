using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField] [TextArea] private string desc;

    public string GetNama() {
        return nama;
    }

    public string GetDesc() {
        return desc;
    }
}
