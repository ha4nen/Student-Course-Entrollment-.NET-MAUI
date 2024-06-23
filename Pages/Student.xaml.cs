using Project.Models;

namespace Project;

public partial class Student : ContentPage
{



    public Student()
	{
		InitializeComponent();
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
    }

    private void Button_Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddS(new Models.StudentClass
        {
            Student_Name = Student_Name.Text,
            Student_Department = Student_Department.Text,
        });
        Student_Name.Text = string.Empty;
        Student_Department.Text = string.Empty;

    }

    private void Button_show_Clicked(object sender, EventArgs e)
    {
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();

    }

    private void Button_delete_Clicked(object sender, EventArgs e)
    {
        if (Global.selectedStudent != null)
        {
            App.DBTrans.DeleteS(Global.selectedStudent.Student_Id);

            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();


            Global.selectedStudent = null;

            DisplayAlert("Success", "Student deleted successfully.", "OK");
        }
        else
        {
            DisplayAlert("Error", "No student selected.", "OK");
        }
    }
    private void Stu_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Global.selectedStudent = e.Item as StudentClass;
    }

}

        
