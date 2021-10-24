using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Primitive/Int")]
public class IntData : BaseData<int>
{
    public int Increment()
    {
        Value++;

        NotifyListeners(Value);
        
        return Value;
    }


    private void OnDestroy()
    {
        Value = 0;
    }
}
