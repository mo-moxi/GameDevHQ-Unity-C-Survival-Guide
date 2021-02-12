using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    protected string branchName;
    protected string location;
    protected string cashInVault;

    protected void CheckBalance()
    {
        Debug.Log("Checking balance: " + branchName);
    }

    protected void Withdraw()
    {
        Debug.Log("Withdrawling from: " + branchName);
    }
    protected void Deposit()
    {
        Debug.Log("Depositing to: " + branchName);
    }
}
