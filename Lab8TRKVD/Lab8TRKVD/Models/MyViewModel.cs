using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab8TRKVD.Models
{
    public class MyViewModel
    {
        public string TextValue { get; set; }
        public int NumericValue { get; set; }
        public string Password { get; set; }
        public bool IsChecked { get; set; }
        public string SelectedOption { get; set; }
        public string SelectedValue { get; set; }

        public List<SelectListItem> SelectListItems { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Опція 1" },
            new SelectListItem { Value = "2", Text = "Опція 2" },
            new SelectListItem { Value = "3", Text = "Опція 3" }
        };
    }
}