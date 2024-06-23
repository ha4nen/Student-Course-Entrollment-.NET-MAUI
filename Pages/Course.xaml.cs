using Project.Models;

namespace Project;

public partial class Course : ContentPage
{

    public Course()
	{
		InitializeComponent();
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();

    }

    private void Button_Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddC(new Models.CourseClass
        {
            Course_Code = Course_Code.Text,
            Course_Name = Course_Name.Text,
        });
        Course_Code.Text = string.Empty;
        Course_Name.Text = string.Empty;

    }

    private void Button_show_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();

    }

    private void Button_delete_Clicked(object sender, EventArgs e)
    {
        if (Global.selectedCourse != null)
        {
            App.DBTrans.DeleteC(Global.selectedCourse.Course_Id);

            Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();


            Global.selectedCourse = null;

            DisplayAlert("Success", "Course deleted successfully.", "OK");
        }
        else
        {
            DisplayAlert("Error", "No course selected.", "OK");
        }
    }

    private void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Global.selectedCourse = e.Item as CourseClass;
    }
}