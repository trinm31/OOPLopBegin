using System;
using Inheritance;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
           // public -- quyền access rộng rãi nhất -- đâu access cũng dc
           // internal -- nếu ở bên trong 1 project thì giống y như public
           //   nhưng phạm vi của internal thif chỉ bên trong project
           // protected -- nếu ở trong class thì như thằng private
           //   nhưng cho phep class con kế thừa có quyền access
           // private -- chỉ bên trong class mới có thể access

           // var testPulic = new TestPublic();
           // var a = testPulic.ForFun;

           var testPrivate = new TestPrivate();
           var a = testPrivate._test;

           var baseClass = new BaseClass();
           var test = baseClass._test;
        }
    }
}