using Lab5TRKVD.Models;

namespace Lab5TRKVD.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Person> People { get; set; } = new List<Person>();
        public IEnumerable<CompanyModel> Companies { get; set; } = new List<CompanyModel>();
    }
}
