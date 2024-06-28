using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescHandler : MonoBehaviour {
    private bool[] isMarker;
    private GameObject animals;
    private int hitungMarker;
    [SerializeField] int jmlMarker;
    [SerializeField] private Text txNama, txDesc;

    void Start() {
        isMarker = new bool[jmlMarker];
    }

    public void setMarkerOn(int indexMarker) {
        if (!isMarker[indexMarker]) {
            isMarker[indexMarker] = true;
            hitungMarker++;
        }
    }

    public void setMarkerOff(int indexMarker) {
        if (isMarker[indexMarker]) {
            isMarker[indexMarker] = false;
            hitungMarker--;
        }
    }

    public void setAnimal(GameObject animals) {
        this.animals = animals;
    }

    private void setUI(bool b) {
        txNama.transform.parent.gameObject.SetActive(b);
        txDesc.transform.parent.gameObject.SetActive(b);
    }

    void Update() {
        if (hitungMarker == 0) {
            setUI(false);

            return;
        }

        if (animals != null) {
            setUI(true);
            for (int i = 0; i < isMarker.Length; i++) {
                txNama.text = animals.GetComponent<Animals>().GetNama();
                txDesc.text = animals.GetComponent<Animals>().GetDesc();
            }
        }
    }
}
