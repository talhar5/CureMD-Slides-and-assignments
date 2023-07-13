using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    // Declaring an interface ISoundBehaviour. This is an example of Polymorphism.
    // Polymorphism allows objects of different classes to be treated as objects of a common superclass or interface.
    // Here, any class that implements ISoundBehaviour can be used wherever ISoundBehaviour is expected.
    public interface ISoundBehaviour
    {
        void MakeSound();
    }
}
