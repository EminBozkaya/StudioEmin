using PhotoEmin.Model;
using System.Data;

namespace PhotoEmin.Services
{
    public interface IDatabaseService
    {
        bool CheckDatabaseExists();
        void CreateDatabase();
        void CreateTable();
        void RemoveDatabase();
        DataTable SearchCustomers(string searchText);
        (string? folderName, byte[]? photoData) GetCustomerDetail(int id);
        void UpdateCustomerName(int id, string newFullName);
        void DeleteCustomer(int id);
        RecordStatus RecordFoldersToDB(string folderPath, string[] subDirectories);
        RecordStatus ImportSpareToArchive(string folderPath);
        List<(string fullName, string folderName, byte[]? photoData, DateTime createDate)> ExportAllCustomers();
    }
}
