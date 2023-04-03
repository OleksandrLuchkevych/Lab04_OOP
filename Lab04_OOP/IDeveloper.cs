using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_OOP
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { set; get;  }

        void Create(int i);

        void Destroy(int j);
        
    }
}
