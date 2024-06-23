using Project.Models;

namespace Project;

public partial class Entroll : ContentPage
{

    public Entroll()
	{
		InitializeComponent();
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
        Enrollments_List_View.ItemsSource = App.DBTrans.GetAllEntroll();

    }

    private void Stu_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Global.selectedStudent = e.Item as StudentClass;

    }

    private void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Global.selectedCourse = e.Item as CourseClass;

    }

    private void Button_Add_Clicked(object sender, EventArgs e)
    {

            if (Global.selectedStudent != null && Global.selectedCourse != null)
            {
                App.DBTrans.AddE(new EntrollClass
                {
                    Student_Id = Global.selectedStudent.Student_Id,
                    Course_Code = Global.selectedCourse.Course_Code
                });
            }
            else
            {
                DisplayAlert("Error", "Please select a student and a course.", "OK");
            }

    }

    private void Button_show_Clicked(object sender, EventArgs e)
    {
        Enrollments_List_View.ItemsSource = App.DBTrans.GetAllEntroll();


    }

    private void Button_delete_Clicked(object sender, EventArgs e)
    {
        if (Global.selectedEntroll != null)
        {
            App.DBTrans.DeleteE(Global.selectedEntroll.Entroll_Id);

            Enrollments_List_View.ItemsSource = App.DBTrans.GetAllEntroll();


            Global.selectedEntroll = null;

            DisplayAlert("Success", "Enrollment deleted successfully.", "OK");
        }
        else
        {
            DisplayAlert("Error", "No Enrollment selected.", "OK");
        }
    }

    private void Enrollments_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Global.selectedEntroll = e.Item as EntrollClass;

    }
}
