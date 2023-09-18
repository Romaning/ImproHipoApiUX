using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproHipoApiUX.MemoryCaching.Service;

public interface ICacheService
{
    T GetData<T>(string key);
    bool SetData<T>(string key, T value, DateTimeOffset expiration);
    Object RemoveData<T>(string key);
}
