using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenrenCore.CacheService
{

    internal interface ICacheChip
    {
        event ChipCompleteEventHandler Completed;
        CacheStatus Status { get; set; }
        string Ouput();
        void Input(string src);
    }
}
