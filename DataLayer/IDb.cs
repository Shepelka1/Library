using System.Collections.Generic;

namespace DataLayer
{
    public interface IDb<T, K>
    {
        void Create(T item);

        T ReadOne(K id);

        List<T> ReadAll();

        void Update(T item);

        void Delele(K id);
    }
}
