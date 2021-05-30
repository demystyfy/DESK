using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.DB;

namespace CombineParameters

{
    /// <summary>
    /// Interaction logic for UserWindRoom.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        SortedList<string, Category> _categories;

        public UserWindow(SortedList<string, Category> elements)
        {
            InitializeComponent();

            _categories = elements;

            foreach (KeyValuePair<string, Category> cat in elements)
            {
                CheckBox cb = new CheckBox();
                cb.Content = cat.Key;
                stackPanel.Children.Add(cb);
               
            }






        }

        //public void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    // IS THIS NECESSARY?
        //    //if (AllTheCategories.SelectedItem is null)
        //    //{
        //    //}


        //    //else if (AllTheCategories.SelectedItem is KeyValuePair<string, object> keyValuePair)
        //    //{
        //    //   Category category = (Category)keyValuePair.Value;
                
        //    //    //MANAGING SETTINGS FILE
        //    //    Set1.Default.SelectingCategory = category.Name;

        //    //    Set1.Default.Save();
        //    //    // var category = keyValuePair.Value;
        //    //}

        //}

        private void ButtonCancelClick(object sender, RoutedEventArgs e)
        {
           
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Set1.Default.SelectingCategory);
            //Set1.Default.Save();
            UserWindowParameters UWP = new UserWindowParameters();
            UWP.Show();
        }


        //string myStringUser = Set1.Default.SelectingCategory;
        // =Set1.Default.SelectingCategory;


    }
}





/*
foreach (KeyValuePair<string, Category> item in AllTheCategories.Items)
{
item.Key
}
*/



//myCategories = elements;
//AllTheCategories.ItemsSource = myCategories;
////AllTheCategories.SelectedIndex = 0;
//AllTheCategories.DisplayMemberPath = "Key";
//AllTheCategories.SelectionChanged += OnSelectionChanged;



























































/*
 public UserWindow(SortedList<string, Category> elements)
        {
            InitializeComponent();

            myCategories = elements;
            AllTheCategories.ItemsSource = myCategories;

            AllTheCategories.DisplayMemberPath = "Key";

        }
*/
