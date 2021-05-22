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
        SortedList<string, Category> myCategories;

        public UserWindow(SortedList<string, Category> elements)
        {
            InitializeComponent();



            AllTheCategories.ItemsSource = elements;

            AllTheCategories.SelectedIndex = 0;


            AllTheCategories.DisplayMemberPath = "Key";
            AllTheCategories.SelectionChanged += OnSelectionChanged;
            
            
            foreach (KeyValuePair<string, Category> item in AllTheCategories.Items)

            {
            item.Key

            }

        
        }


        public void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AllTheCategories.SelectedItem is null)
            {
            }
            else if (AllTheCategories.SelectedItem is KeyValuePair<string, object> keyValuePair)
            {
               Category category = (Category)keyValuePair.Value;
                // var category = keyValuePair.Value;
                Set1.Default.SelectingCategory = category.Name;
                Set1.Default.Save();
            }

        }





        private void ButtonCancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Set1.Default.Save();
            this.Close();
        }


        //string myStringUser = Set1.Default.SelectingCategory;

        // =Set1.Default.SelectingCategory;


    }
}


































































/*
 public UserWindow(SortedList<string, Category> elements)
        {
            InitializeComponent();

            myCategories = elements;
            AllTheCategories.ItemsSource = myCategories;

            AllTheCategories.DisplayMemberPath = "Key";

        }
*/
