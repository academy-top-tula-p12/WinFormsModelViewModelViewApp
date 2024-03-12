namespace WinFormsModelViewModelViewApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Employee employeeObj = new Employee() { Name = "Bobby", Age = 32 };
            this.DataContext = employeeObj;

            //Binding binding = new Binding("Text", txtName, "Text");
            //binding.Format += (sender, e) => e.Value = $"Hello {e.Value}";

            //lblTarget.DataBindings.Add(binding);

            Binding bindingName = new("Text", this.DataContext, "Name");
            bindingName.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            txtName.DataBindings.Add(bindingName);

            lblName.DataBindings.Add(new("Text", this.DataContext, "Name"));


            Binding bindingAge = new("Text", this.DataContext, "Age");
            bindingAge.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            txtAge.DataBindings.Add(bindingAge);

            lblAge.DataBindings.Add(new("Text", this.DataContext, "Age"));

        }

        private void btnChancgeName_Click(object sender, EventArgs e)
        {
            (this.DataContext as Employee).Name = "Sammy";
            (this.DataContext as Employee).Age = 25;

            //string str = $"{this.DataContext.Name} {this.DataContext.Age}";
            //MessageBox.Show(str);
        }
    }
}
