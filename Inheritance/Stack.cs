using System;

namespace CSharpIntermediate
{
 public class Stack
 {

     private readonly List<object> _objectList = new List<object>();
     public void Push(object obj)
     {
       _objectList.Add(obj);
     }
    
    public object Pop()
    {
        var last= _objectList.last();
        _objectList.Remove(last);
        return last;
    }
     public void Clear()
     {
         _objectList.Clear();
     }

 }



}

