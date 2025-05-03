

namespace DalApi
{
    public interface ICrud<T>
    {
        int Create(T item); //יצירת אוביקט
        T? Read(int id); //חיפוש אוביקט עי מספרו 
        List<T?> ReadAll(Func<T, bool>? filter = null); //מחזיר רשימה של האוביקטים
        void Update(T item); //מעדכן את האוביקט
        void Delete(int id); //מוחק אוביקט

        T? Read(Func<T, bool> filter );
    }
}
