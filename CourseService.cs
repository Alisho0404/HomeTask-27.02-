namespace HomeTask_27._02_;

public class CourseService
{
 List<Course>_courses=new List<Course>();

    public List<Course> GetAll()
    {
        return _courses;
    } 

    

    public void CreateCourse(Course course)
    {
        _courses.Add(course);
    } 

    public void UpdateCourse(Course course)
    {        
        Course kurs = _courses.Find(course=>course.Id==course.Id);
        if (kurs!=null)
        {
            kurs.CourseName = course.CourseName;
            kurs.Descripttion = course.Descripttion; 
            kurs.PriceofCourse=course.PriceofCourse; 
            kurs.HasDiscount=course.HasDiscount; 
            kurs.Days=course.Days; 
            kurs.Duration=course.Duration; 
            
        }
    } 

    public void DeleteCourse(int id)
    {
        _courses.RemoveAll(course=>course.Id==id);   
    } 

    public void GetByID(int id)
    {
        Course courseGet = _courses.Find(course=>course.Id==id);
    }
}
