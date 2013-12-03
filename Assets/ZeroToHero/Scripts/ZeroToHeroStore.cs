using UnityEngine;
using System.Collections;

public class ZeroToHeroStore : MonoBehaviour {

    public GameObject leaveButton;
    public GameObject StorePanel;

    void Start()
    {
        UIEventListener.Get(leaveButton).onClick += OnLeaveButtonClicked;
    }

    void OnLeaveButtonClicked(GameObject leaveButton)
    {
        LeaveZeroToHeroStore();
    }

    public void EnterZeroToHeroStore()
    {
        StorePanel.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void LeaveZeroToHeroStore()
    {
        StorePanel.transform.localPosition = new Vector3(1500, 0, 0);
    }
}
