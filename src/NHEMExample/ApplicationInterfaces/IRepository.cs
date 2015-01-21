using System.Collections;
using System.Collections.Generic;

namespace ApplicationInterfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
    }
}
