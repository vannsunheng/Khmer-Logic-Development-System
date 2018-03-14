public interface IPage
{
    void AddNew();
    void Remove();
    void Edit();
    void View();
    void Search();
    void Reload();
    void Clear();
    void Search(string testValue, string column = "");
}