using System;
using System.Collections;
class MyCollection : IEnumerable
{
    int[] data = {1,2,3};
    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }
}
