using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    public string branchName;
    public string location;
    public string cashInVault;

    public void CheckBalance()
    {
        Debug.Log("Checking balance: " + branchName);
    }

    public void Withdraw()
    {
        Debug.Log("Withdrawling from: " + branchName);
    }
    public void Deposit()
    {
        Debug.Log("Depositing to: " + branchName);
    }
}
