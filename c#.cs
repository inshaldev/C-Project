// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WEEK5LAB2App1
{
    public partial class Form1 : Form
    {
        
        Dictionary<string, List<string>> categoryData;

        public Form1()
        {
            InitializeComponent();
            LoadCategoryData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbxcategory.DataSource = new BindingSource(categoryData.Keys, null);
        }

        
        private void LoadCategoryData()
        {
            categoryData = new Dictionary<string, List<string>>()
            {
                { "Electronics", new List<string>(){ "Mobile", "Laptop", "Tablet" } },
                { "Clothing", new List<string>(){ "Men", "Women", "Kids" } },
                { "Grocery", new List<string>(){ "Fruits", "Vegetables", "Snacks" } },
                { "Books", new List<string>(){ "Fiction", "Non-Fiction", "Comics" } }
            };
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbxcategory.SelectedItem.ToString();

            if (categoryData.ContainsKey(selectedCategory))
            {
                cmbxsubcategory.DataSource = categoryData[selectedCategory];
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string productId = txtpid.Text;
            string productName = txtpname.Text;
            string category = cmbxcategory.SelectedItem?.ToString() ?? "";
            string subCategory = cmbxsubcategory.SelectedItem?.ToString() ?? "";
            bool isAvailable = cboxavailable.Checked;

            string message = $"Product ID: {productId}\n" +
                             $"Product Name: {productName}\n" +
                             $"Category: {category}\n" +
                             $"Sub Category: {subCategory}\n" +
                             $"Available: {isAvailable}";

            MessageBox.Show(message, "Product Information");
        }
    }
} 
    }
}
